namespace Exercicio22;

//22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

internal class Program
{
    static double Phi = (1 + Math.Sqrt(5)) / 2;
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora sequência de Fibonacci=+-");
        Console.Write("Digite um quantos números deseja -> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        double[] sequencia = new double[numero];
        for (int i = 0; i < numero; i++)
        {
            sequencia[i] = (Math.Pow(Phi, i) - Math.Pow(1 - Phi, i)) / Math.Sqrt(5.0);
        }
        for (int i = 0; i < numero; i++)
        {
            if (i < numero - 1)
                Console.Write($"{sequencia[i]:F0}, ");
            else if (i == numero - 1)
                Console.Write($"{sequencia[i]:F0}");
        }
        Console.WriteLine("\n\nAperte qualquer tecla para rodar o outro método...\n");
        Console.ReadKey();

        OutraForma();
    }
    static void OutraForma() // Essa aqui começa a errar dps de 48 números
    {
        Console.WriteLine("-+=Calculadora sequência de Fibonacci=+-");
        Console.Write("Digite um quantos números deseja -> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int[] sequencia = new int[numero];
        sequencia[0] = 0;
        sequencia[1] = 1;
        for (int i = 2; i < numero; i++)
        {
            sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
        }
        Console.Write(string.Join(", ", sequencia));
        Console.WriteLine();
        Console.ReadKey();
    }
}
