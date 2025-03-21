using System.Numerics;

namespace Exercicio21;

//21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
//resultado.
//a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//b.Pesquise sobre “fatorial”

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de fatorial=+-");
        Console.Write("Digite um número -> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        BigInteger fatorial = numero;
        if (numero > 1)
        {
            Console.Write($"{numero}! = {numero} × ");
            for (int i = 1; i < numero; i++)
            {
                fatorial *= numero-i;
                if (numero - i > 1)
                    Console.Write($"{numero - i} × ");
                else
                    Console.Write($"{numero - i} = {fatorial}");
            }
        }
        else if (numero == 1 || numero == 0)
        {
            Console.Write($"{numero}! = 1");
        }
        else
        {
            Console.WriteLine($"{numero}! = Indefinido");
        }
            Console.ReadKey();

    }
}
