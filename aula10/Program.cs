using Aula10_EF.Models;

class Program{
    public static void Main(string[] args){
        using (var context = new PessoaContext()){

            // Criar o banco de dados se ele não existir 
            context.Database.EnsureCreated();

            // Adicionar uma nova pessoa ao banco 
            var pessoa = new Pessoa{
                Nome = "John",
                Idade = 33
            };

            context.Pessoas.Add(pessoa);
            context.SaveChanges();
            
            //Listar as pessoas cadastradas
            var listaPessoas = context.Pessoas.ToList();
            foreach(var p in listaPessoas){
                Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
            }
        }
    }
}