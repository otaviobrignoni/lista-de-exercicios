namespace Exercicio16;

//16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Verificador de par/impar=+-");
        Console.Write("Digite um número -> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
            Console.WriteLine("O número é par");
        else
            Console.WriteLine("O número é ímpar");
        Console.ReadKey();
    }
}
