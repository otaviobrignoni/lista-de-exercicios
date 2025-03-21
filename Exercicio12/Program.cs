namespace Exercicio12;

//12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
//impostos.Imprima o salário inicial, o salário com o aumento e o salário final.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de aumento com IR=+-");
        Console.Write("Digite o salário atual -> ");
        decimal salarioAtual = Convert.ToDecimal(Console.ReadLine());
        decimal salarioAumento = (salarioAtual * 1.15m) * 0.92m;
        Console.WriteLine($"Salário inical: R${salarioAtual:F2}\nSalário final R${salarioAumento:F2}");
        Console.ReadKey();
    }
}
