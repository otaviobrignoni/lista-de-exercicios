namespace Exercicio04;

//4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Conversor de temperatura=+-");
        Console.Write("Digite a temperatura em C° -> ");
        double celcius = Convert.ToDouble(Console.ReadLine());
        double farenheit = ((9.0 / 5) * celcius) + 32;
        Console.WriteLine($"A temepratura em farenheit é {farenheit}");
        Console.ReadKey();
    }
}
