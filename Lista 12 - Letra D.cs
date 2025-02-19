using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<string> palavras = new List<string> { "banana", "programação", "computador", "AI", "dados" };

        string maisLonga = string.Empty; 

        foreach (string palavra in palavras)
        {
            if (palavra.Length > maisLonga.Length)
            {
                maisLonga = palavra; 
            }
        }

        Console.WriteLine($"A string mais longa na lista é: {maisLonga}");
    }
}
