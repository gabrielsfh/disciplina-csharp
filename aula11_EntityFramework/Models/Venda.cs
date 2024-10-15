namespace Aula11_EntityFramework.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<Livro> Livros { get; set; }

        public Venda()
        {
            Cliente = new Cliente("", 0);
            Livros = new List<Livro>();
        }

        public Venda(Cliente cliente)
        {
            Cliente = cliente;
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public decimal CalcularTotal()
        {
            return Livros.Sum(l => l.Preco); // Fixed: Changed 'preco' to 'Preco'
        }

        public override string ToString()
        {
            string livrosStr = string.Join(", ", Livros.Select(l => l.Nome));
            return $"Venda para {Cliente.Nome}, Livro(s): [{livrosStr}], Total: {CalcularTotal():C}";
        }

        

        // // Com base na linha 34, quais serão os livros que serão impressos? (suposta questão de prova)
        // Variável lista livrosCaros é uma lista devido ao .ToList()
        public void ListarLivroMaisCaros(decimal precoMinimo)
        {
            var livrosCaros = Livros.Where(l => l.Preco > precoMinimo).OrderBy(l => l.Nome).ToList();
            /* O 'l' representa um objeto da lista 'livrosCaros'.
                 O método ForEach é utilizado aqui para iterar sobre cada livro na lista 
                 e imprimir suas informações, aplicando uma expressão lambda para facilitar a iteração. */

            if (livrosCaros.Count > 0)
            {
                Console.WriteLine($"Livros com o preço maior que {precoMinimo:C}");
                livrosCaros.ForEach(l => Console.WriteLine(l));
            }
            else
            {
                Console.WriteLine($"Nenhum livro com o preço maior que {precoMinimo:C}");
            }
        }

        public void LivrosEmOrdem()
        {
            var livrosOrdenados = Livros.OrderBy(l => l.Nome).ToList();
            livrosOrdenados.ForEach(l => Console.WriteLine(l));
        }
    }
}