namespace Exercicio13;

//13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Soma de A + B é menor que C?=+-");
        Console.Write("Digite o valor de A -> ");
        decimal a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o valor de B -> ");
        decimal b = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o valor de C -> ");
        decimal c = Convert.ToDecimal(Console.ReadLine());
        if ((a + b) < c)
            Console.WriteLine("A + B é menor que C");
        else
            Console.WriteLine("A + B não é menor que C");
        Console.ReadKey();
    }
}
