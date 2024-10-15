using System;
using System.Linq;
using Aula11_EntityFramework.Models;
using Aula11_EntityFramework; 

namespace Aula11_EntityFramework
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                Cliente cliente1 = new Cliente("Rafael", 33);
                Cliente cliente2 = new Cliente("João", 32);

                db.Cliente.Add(cliente1);
                db.Cliente.Add(cliente2);
                db.SaveChanges();

                Livro livro1 = new Livro("SLA", 45.00M);
                Livro livro2 = new Livro("SLA parte 4", 120.00M);
                db.Livro.AddRange(livro1, livro2);
                db.SaveChanges();
                
                Venda venda1 = new Venda(cliente1);
                venda1.AdicionarLivro(livro1);
                venda1.AdicionarLivro(livro2);

                db.Vendas.Add(venda1);
                db.SaveChanges();

                Console.WriteLine(venda1);
            }
        }
    }
}
