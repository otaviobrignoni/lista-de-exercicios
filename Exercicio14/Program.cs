namespace Exercicio14;

//14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Ordem decrescente=+-");
        int[] valores = new int[3];
        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write($"Digite o {i + 1}° número -> ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(valores);
        Array.Reverse(valores);
        Console.WriteLine(string.Join(", ", valores));
        Console.ReadKey();
    }
}



















