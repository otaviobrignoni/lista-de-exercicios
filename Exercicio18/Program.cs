namespace Exercicio18;

//18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Gerador de números impares entre 100 e 200=+-");
        
        for (int i = 101, praBonito = 1; i < 200; i += 2, praBonito++)
        {
            Console.Write($"{i} ");
            if (praBonito % 5 == 0)
                Console.WriteLine();            
        }
        Console.ReadKey();
    }
}
