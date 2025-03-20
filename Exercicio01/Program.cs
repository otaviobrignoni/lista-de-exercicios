namespace Exercicio01;

//1. Crie um programa para calcular o volume de uma caixa retangular

internal class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de volume(em cm)=+-");
        Console.Write("\nDigite o comprimento -> ");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite a largura -> ");
        double largura = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite a altura -> ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double volume = largura * comprimento * altura;
        Console.WriteLine($"\n O volume da caixa informada é {volume} cm³");
        Console.ReadKey();    
    }
}
