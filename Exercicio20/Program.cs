namespace Exercicio20;

//20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.Mostre a
//tabuada na forma:
//  ● 0 x N = 0,
//  ● 1 x N = 1N,
//  ● 2 x N = 2N,
//  .
//  .
//  .
//  ● 10 x N = 10N.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora tabuada=+-");
        Console.Write("Digite um número -> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        decimal timesTable = numero;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} × {i} = {timesTable}");
            timesTable += numero;
        }
        Console.ReadKey();
    }
}
