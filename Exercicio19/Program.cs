namespace Exercicio19;

//19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
//encontram no conjunto dos números de 1 até 500.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Soma de todos os números entre 1 e 500 que são ímpares e multiplos de 3=+-");
        for (int i = 1, praBonito = 1; i < 500; i++, praBonito++)
        {
            if (i % 2 != 0 && i % 3 == 0)
            {
                Console.Write($"{i} ");
                if (praBonito % 5 == 0)
                    Console.WriteLine();
            }
        }
        Console.ReadKey();
    }
}
