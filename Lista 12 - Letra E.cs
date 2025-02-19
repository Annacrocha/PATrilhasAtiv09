using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 15, 26, 02, 09, 12 };
        int soma = 0;
        int cont = 0;

        foreach (int numero in numeros)
        {
            soma += numero;
            cont++;
        }
        double media = (double)soma / cont;

        Console.WriteLine($"A média dos números é {media}");

    }
}
