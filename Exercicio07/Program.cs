using System.Threading.Channels;

namespace Exercicio07;

// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Média ponderada de duas notas=+-");
        Console.Write("Digite a primeira nota -> ");
        float nota1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Digite a segunda nota -> ");
        float nota2 = Convert.ToSingle(Console.ReadLine());

        float mediaPonderada = ((nota1 * 1) + (nota2 * 1)) / (1 + 1);
        
        Console.WriteLine($"A média ponderada é {mediaPonderada}");
        Console.ReadKey();
    }
}
