using System;

public class Program {

    public delegate void ExibirNumero(int numero);

    public static void ImprimeNumero(int numero){
        Console.WriteLine("O número é: " + numero);
    }

    public static void ExibirQuadrado(int numero){
        Console.WriteLine("O quadrado do numero " + numero + " é: " + numero*numero);
    }

    public static void VerificarNota(int nota){
        if (nota>60){
            Console.WriteLine("Aluno foi aprovado com a nota: " + nota);
        } else {
            Console.WriteLine("Aluno foi reprovado com a nota: " + nota);
        }
    }

    public static void Main(){
        ExibirNumero meuDelegate = ImprimeNumero;
        meuDelegate(10);
        
        meuDelegate += ExibirQuadrado;
        meuDelegate(2);

        meuDelegate += delegate (int num){
            Console.WriteLine("O dobro do número " + num + " é " + (num*2));
        };
        meuDelegate(3);

        Pessoa aluno = new Pessoa("Juca", 70);
        meuDelegate += VerificarNota;
        meuDelegate(aluno.Nota);
    }

}