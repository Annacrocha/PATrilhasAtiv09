using System;
    public class Banco
    {
        public string AbrirConta(string tipo, string nome, string cpf)
        {
            return  $"Conta aberta com sucesso! Nome: {nome}, Tipo: {tipo}, CPF: {cpf}";

        }

        public string FecharConta(string tipo, string nome, string cpf)
        {
            return $"{nome} sua conta {tipo} foi fechada com sucesso!";
        }
        public double Depositar(double saldo, double valor)
        {
            return saldo + valor;
        }

        public double Sacar(double saldo, double valor)
        {
            return saldo - valor;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO AO BANCO");
            Console.WriteLine("Por favor, insira os seguintes dados:");
            Console.WriteLine("Tipo de conta:");
            string tipo = Console.ReadLine();
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();
            
            string cpf;
            do
            {
                Console.WriteLine("Informe seu CPF (apenas números):");
                cpf = Console.ReadLine();
            } 
            while (cpf.Length != 11 || !long.TryParse(cpf, out _));

           
            Banco banco = new Banco();
            
            int opcao = 0;
            {
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Abrir conta");
                Console.WriteLine("2 - Fechar conta");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("4 - Sacar");
                opcao = int.Parse(Console.ReadLine());

                string escolha;
                switch (opcao)
                {
                    case 1: 
                        escolha = banco.AbrirConta(tipo, nome, cpf);
                        Console.WriteLine(escolha);
                        break;
                    case 2: 
                        escolha = banco.FecharConta(tipo, nome, cpf);
                        Console.WriteLine(escolha);
                        break;
                    case 3:
                        Console.WriteLine("Informe seu saldo atual: ");
                        double saldo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor a ser depositado: ");
                        double valor = double.Parse(Console.ReadLine());
                        double deposito = banco.Depositar(saldo, valor);
                        Console.WriteLine($"Depósito realizado! Saldo atual: R$ {deposito}");
                        break;
                    case 4:
                        Console.WriteLine("Informe seu saldo atual: ");
                        double saldo2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor a ser sacado: ");
                        double valor2 = double.Parse(Console.ReadLine());
                        double saque = banco.Sacar(saldo2, valor2);
                        Console.WriteLine($"Saque realizado! Saldo atual: R$ {saque}");
                        break;
                }
            }
        }
    }
