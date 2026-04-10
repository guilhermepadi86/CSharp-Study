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
    Console.Clear();
    
    switch (escolha)
    {
        case 1:
        {
            Console.WriteLine("Digite o valor 1: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            int valorB = int.Parse(Console.ReadLine());
            int resultado = valorA + valorB;
            Console.WriteLine($"{valorA} + {valorB} = {resultado}");
            break;
        }
        case 2:
        {
            Console.WriteLine("Digite o valor 1: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            int valorB = int.Parse(Console.ReadLine());
            int resultado = valorA - valorB;
            Console.WriteLine($"{valorA} - {valorB} = {resultado}");
            break;
        }
        case 3:
        {
            Console.WriteLine("Digite o valor 1: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            int valorB = int.Parse(Console.ReadLine());
            int resultado = valorA * valorB;
            Console.WriteLine($"{valorA} x {valorB} = {resultado}");
            break;
        }
        case 4:
        {
            Console.WriteLine("Digite o valor 1: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            int valorB = int.Parse(Console.ReadLine());
            if (valorB == 0)
            {
                Console.WriteLine("O divisor não pode ser igual a 0");
                break;
            }
            int resultado = valorA / valorB;
            Console.WriteLine($"{valorA} / {valorB} = {resultado}");
            break;
        }
        case 0:
        {
            Console.Clear();
            Console.WriteLine("Finalizando...");
            return;
        }
        default:
        {
            break;
        }
    }
}

