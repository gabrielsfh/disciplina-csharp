using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {   
        List<Pessoa> listaPessoa = new List<Pessoa>();
        Pessoa obj1 = new Pessoa("Gabriel", 20);
        listaPessoa.Add(obj1);  // Corrected method name and variable

        // Passando o tipo Pessoa para a classe generica
        Caixa<Pessoa> objGenericoPessoa = new Caixa<Pessoa>(obj1);  // Fixed variable name
        // Passando o tipo String para a classe generica
        Caixa<string> objGenericoString = new Caixa<string>("Uau");  // Changed String to string

        objGenericoPessoa.MostrarConteudo();
        objGenericoString.MostrarConteudo();

        Console.WriteLine(obj1.ToString());
    }
}

// Classe generica
public class Caixa<T>
{
    private T conteudo;
    
    public Caixa(T conteudoInicial)
    {
        conteudo = conteudoInicial;  
    }
    
    public T Conteudo
    {
        get { return conteudo; }
        set { conteudo = value; }
    }
    
    public void MostrarConteudo()
    {
        Console.WriteLine($"Conteudo: {conteudo}");
    }
}

public class Pessoa
{
    private string nome; 
    private int idade;
    
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }
    
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade; 
    }
    
    public override string ToString()
    {
        // Interpolação 
        return $"Nome: {Nome}, idade: {Idade}";  
    }
}
