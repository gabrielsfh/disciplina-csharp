using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Conversão implícita de INT para DOUBLE
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversão implícita de int para double:");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");

        // Conversão explícita usando o Convert
        double valorDouble = 7.45;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);

        Console.WriteLine($"Double: {valorDouble}, Inteiro: {valorConvertidoInt}");
        Console.WriteLine($"String: {textoValor}, Inteiro: {textoConvertidoInt}");
    }
}
