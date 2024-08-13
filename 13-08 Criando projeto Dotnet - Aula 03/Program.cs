using System;

class Program{
    static void Main(string[] args){
        
        Console.WriteLine("Cadastro de Pessoa!");
        Console.Write("Nome: ");
        string nomePessoa = Console.ReadLine();
        Console.Write("Idade: ");
        int idadePessoa = int.Parse(Console.ReadLine()); //Converte o valor String para Int

        Pessoa pessoa = new Pessoa(nomePessoa, idadePessoa);

        Console.WriteLine(pessoa.ToString());

    }
}