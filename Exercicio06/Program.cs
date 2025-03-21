namespace Exercicio06;

// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Média harmônica de notas=+-");
        float[] notas = new float[5];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a {i+1}º nota -> ");
            notas[i] = Convert.ToSingle(Console.ReadLine()!);
        }
        float mediaHarmonica = notas.Length / ((1.0f / notas[0]) + (1.0f / notas[1]) + (1.0f / notas[2]) + (1.0f / notas[3]) + (1.0f / notas[4]));
        Console.WriteLine($"A média harmônica dessas notas é: {mediaHarmonica}");
        Console.ReadKey();
    }
}
