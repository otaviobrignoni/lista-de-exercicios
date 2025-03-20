namespace Exercicio02;

// 2. Crie um programa para calcular o volume de um Cilindro

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de volume de cilindro(em cm)=+-");
        Console.Write("\nDigite o raio -> ");
        double raio = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite a altura -> ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine($"\n O volume do cilindro informado é {volume} cm³");
        Console.ReadKey();
    }
}
