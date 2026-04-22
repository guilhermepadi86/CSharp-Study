using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int[] numerosAleatorios = new int[10];

        for (int i = 0; i < numerosAleatorios.Length; i++)
        {
            numerosAleatorios[i] = rnd.Next(1, 20);
        }
        string beforeBubbleSort = string.Join(", ", numerosAleatorios);

        for (int i = 0; i < numerosAleatorios.Length; i++)
        {
            if ((i + 1 < numerosAleatorios.Length) && (numerosAleatorios[i] > numerosAleatorios[i + 1]))
            {
                var aux = numerosAleatorios[i + 1];
                numerosAleatorios[i + 1] = numerosAleatorios[i];
                numerosAleatorios[i] = aux;
                i = -1;
            }
        }

        string afterBubbleSort = string.Join(", ", numerosAleatorios);

        Console.WriteLine($"Array antes do BubbleSort: {beforeBubbleSort}\nArray depois do BubbleSort: {afterBubbleSort}");
    }

}