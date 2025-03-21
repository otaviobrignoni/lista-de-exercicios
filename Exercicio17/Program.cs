namespace Exercicio17;

//17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//variável C e mostrar seu conteúdo na tela.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=ABC=+-");
        Console.Write("Digite um valor para A -> ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um valor para B -> ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c;
        if (a == b)
        {
            c = a + b;
            Console.WriteLine($"A = B, Então C = A + B = {c}");
        }
            
        else
        {
            c = a * b;
            Console.WriteLine($"A != B, Então C = A * B = {c}");
        }
        Console.ReadKey();
    }
}
