namespace Exercicio09;

//9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
//   terreno e depois exibir a área do terreno.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calcular área=+-");
        Console.Write("Digite o comprimento -> ");
        decimal comprimento = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a largura -> ");
        decimal largura = Convert.ToDecimal(Console.ReadLine());
        decimal area = comprimento * largura;
        Console.ReadKey();
    }
}
