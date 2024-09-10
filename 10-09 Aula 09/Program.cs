public class Program {
    public static void Main(){
        //Criando clientes
        Cliente cliente1 = new Cliente(1, "Leorio");
        Cliente cliente2 = new Cliente(2, "Pietro");

        // Criando produtos
        Produto produto1 = new Produto(1, "Laptop", 3500.00M);
        Produto produto2 = new Produto(2, "Cooler", 200.00M);
        Produto produto3 = new Produto(3, "Tablet", 1200.00M);
        Produto produto4 = new Produto(4, "Headset", 800.00M);
        
        // Criando compra para o cliente 1
        Compra compra1 = new Compra(cliente1);
        compra1.AdicionarProduto(produto1);
        compra1.AdicionarProduto(produto2);
        compra1.AdicionarProduto(produto4);

        // Criando compra para o cliente 2
        Compra compra2 = new Compra(cliente2);
        compra2.AdicionarProduto(produto3);
        compra2.AdicionarProduto(produto1);  
        compra2.AdicionarProduto(produto2);

        // Exibir as compras
        Console.WriteLine(compra1);
        Console.WriteLine(compra2);  


    }
}