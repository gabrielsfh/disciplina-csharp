using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace prova2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // Adicionando Pessoas e Habilidades (Relacionamento N:N)
                var aluno1 = new Aluno { Nome = "Vinicius", Matricula = "2020", Idade = 20 };
                var aluno2 = new Aluno { Nome = "Gabriel", Matricula = "2022", Idade = 21 };

                var disciplina1 = new Disciplina { NomeDisciplina = "Matematica", CodigoDisciplina = 1 };
                var disciplina2 = new Disciplina { NomeDisciplina = "Portugues",  CodigoDisciplina = 2 };

                aluno1.Disciplinas.Add(disciplina1);
                aluno2.Disciplinas.Add(disciplina2);

                aluno2.Disciplinas.Add(disciplina1); 
                context.Alunos.AddRange(aluno1, aluno2);

                context.Disciplinas.AddRange(disciplina1, disciplina2);
                
                context.SaveChanges();

                // Consultando
                var alunos = context.Alunos.Include(a => a.Disciplinas).ToList();
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"Aluno: {aluno.Nome}, Matricula: {aluno.Matricula}, Idade: {aluno.Idade}");
                    foreach (var disciplina in aluno.Disciplinas)
                    {
                        Console.WriteLine($"Disciplina: {disciplina.NomeDisciplina}, Codigo Disciplina {disciplina.CodigoDisciplina}");
                    }
                }
            }
        }
    }
}
