using System;

class Program{
    


    public static void Main(string[] args){
        //Pessoa objPessoa = new("José"); 
        Pessoa objPessoa = new Pessoa("José"); 
        Console.WriteLine("Antes do método AlterarNomeClasse (Classe):" + objPessoa.ToString());
        AlterarNomeClasse(objPessoa);
        Console.WriteLine("Depois do método AlterarNomeClasse (Classe): " + objPessoa.ToString());

        PessoaStruct pessoaStruct = new PessoaStruct("Joseph");
        Console.WriteLine("Antes do método (struct): " + pessoaStruct.ToString());
        AlterarNomeStruct(pessoaStruct);
        Console.WriteLine("Depois do método (struct): " + pessoaStruct.ToString());
    }

    public static void AlterarNomeClasse(Pessoa objAux){
        objAux.Nome = "Josefina";
    }

    public static void AlterarNomeStruct(PessoaStruct objAux){
        objAux.NomeStruct = "Maria";
    }
}
