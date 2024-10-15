using System.Linq;

namespace aula12_TPT {
    public class Program {
        public static void Main(string[] args){
            using (var context = new AppDbContext()){
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // Adiciona dados de exemplo 
                context.Pessoas.Add(new Aluno{Nome = "João", matricula = "A001"});
                context.Pessoas.Add(new Professor {Nome = "Maria", Disciplina = "IoT"});
                context.SaveChanges();

                var pessoas = context.Pessoas.ToList();
                foreach(var pessoa in pessoas){
                    Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}");
                }

            }
        }
    }
}