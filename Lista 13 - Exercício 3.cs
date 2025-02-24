using System;

public class Produto
{
    public string nome;
    public double precoUnitario;
    public int quantidade;

    public double valorTotal()
    {
        return precoUnitario * quantidade;
    }
}
public class letra_c
{
    public static void Main()
    {
        Produto produto = new Produto(); 
        
        Console.Write("Digite o nome do produto: ");
        produto.nome = Console.ReadLine();
        
        Console.Write("Digite o preço unitário do produto: ");
        produto.precoUnitario = double.Parse(Console.ReadLine());
        
        Console.Write("Digite a quantidade do produto: ");
        produto.quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"O valor total do produto é: {produto.valorTotal():C2}");
    }
}
