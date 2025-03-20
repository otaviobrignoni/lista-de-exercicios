namespace Exercicio03;

//3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.O
//programa deve solicitar ao usuário:
//● A quilometragem inicial do veículo no início da viagem.
//● A quilometragem final ao término da viagem.
//● A quantidade de combustível consumida durante a viagem(em litros).

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de km/l=+-");
        Console.Write("\nDigite a distância inicial -> ");
        double kmInicial = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite a distância final -> ");
        double kmFinal = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite a quantidade de combustível consumido -> ");
        double combustivelConsumido = Convert.ToDouble(Console.ReadLine());
        double kmPorLitro = (kmFinal - kmInicial) / combustivelConsumido;
        Console.WriteLine($"O consumo por Km foi de {kmPorLitro} km/l");
        Console.ReadKey();
    }
}
