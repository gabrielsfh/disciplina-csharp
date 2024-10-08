using System.Linq;

namespace aula12_TPC {
    public class Program {
        public static void Main(string[] args){
            using (var context = new AppDbContext()){
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // Adiciona dados de exemplo 
                context.Pessoas.Add(new Aluno{Nome = "João", matricula = "A001"});
                context.Pessoas.Add(new Professor {Nome = "Maria", Disciplina = "IoT"});
                context.SaveChanges();

                var alunos = context.Alunos.ToList();
                foreach(var aluno in alunos){
                    Console.WriteLine($"Id: {aluno.Id}, Nome: {aluno.Nome}");
                }

                var professores = context.Professores.ToList();
                foreach(var professor in professores){
                    Console.WriteLine($"Id: {professor.Id}, Nome: {professor.Nome}");
                }

            }
        }
    }
}