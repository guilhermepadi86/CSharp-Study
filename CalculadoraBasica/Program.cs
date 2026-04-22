using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n==== Calculadora Básica ====");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair\n");
            Console.WriteLine("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 0)
            {
                Console.Clear();
                Console.WriteLine("Finalizando...");
                break;
            }

            Console.Clear();
            Console.WriteLine("Digite o valor 1: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            int valorB = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                {
                    Soma(valorA, valorB);
                    break;
                }
                case 2:
                {
                    Subtracao(valorA, valorB);
                    break;
                }
                case 3:
                {
                    Multiplicacao(valorA, valorB);
                    break;
                }
                case 4:
                {
                    Divisao(valorA, valorB);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    
    static void Soma(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    static void Subtracao(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    static void Multiplicacao(int a, int b)
    {
        Console.WriteLine($"{a} x {b} = {a * b}");
    }

    static void Divisao(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Divisão por zero é impossivel");
        }
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
}

