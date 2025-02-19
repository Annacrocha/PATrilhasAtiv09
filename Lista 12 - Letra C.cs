using System;

public class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 26, 12, 2, 9, 11, 21 };
        int maior = int.MinValue;

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"O maior número é {maior}");
    }
}
