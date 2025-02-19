using System;
    public class Calculadora
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtracao(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public int Divisao(int a, int b)
        {
            return a / b;
        }
    }

public class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem-vindo à CALCULADORA");
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Calculadora calc = new Calculadora();

            int opcao;
            {
                Console.WriteLine("Escolha uma função da CALCULADORA");
                Console.WriteLine("1. SOMAR");
                Console.WriteLine("2. SUBTRAIR");
                Console.WriteLine("3. MULTIPLICAR");
                Console.WriteLine("4. DIVIDIR");
                opcao = int.Parse(Console.ReadLine());
                
                int resultado;
                switch (opcao)
                {
                    case 1:
                        resultado = calc.Soma(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 2:
                        resultado = calc.Subtracao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 3:
                        resultado = calc.Multiplicacao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 4:
                        resultado = calc.Divisao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            
        }
    }
