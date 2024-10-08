namespace Aula11_EntityFramework.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; } // Fixed: Changed 'idade' to 'Idade'

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}