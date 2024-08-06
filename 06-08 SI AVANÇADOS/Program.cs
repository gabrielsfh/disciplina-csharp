using System;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Digite os dados do Professor");
        Console.WriteLine("Nome: ");
        string nomeProfessor = Console.ReadLine();
        Console.WriteLine("Idade: ");
        int idadeProfessor = int.Parse(Console.ReadLine());
        Console.WriteLine("Disciplina: ");
        string disciplina = Console.ReadLine();

        Console.WriteLine("Digite os dados do Aluno");
        Console.WriteLine("Nome: ");
        string nomeAluno = Console.ReadLine();
        Console.WriteLine("Idade: ");
        int idadeAluno = int.Parse(Console.ReadLine());
        Console.WriteLine("Curso: ");
        string curso = Console.ReadLine();

        Professor objProfessor = new Professor(
            nomeProfessor, idadeProfessor, disciplina);
        
        Aluno objAluno = new Aluno(
            nomeAluno, idadeAluno, curso);

        Console.WriteLine("Dados do Professor: ");
        Console.WriteLine(objProfessor.ToString());

        Console.WriteLine("Dados do Aluno: ");
        Console.WriteLine(objAluno.ToString());
    }
}