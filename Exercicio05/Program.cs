namespace Exercicio05;

//5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
//   vendas. A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de salário=+-");
        Console.Write("Digite o salário base -> ");
        decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o total de vendas -> ");
        int totalVendas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a porcentagem da comissção -> ");
        decimal percentual = (Convert.ToDecimal(Console.ReadLine()) / 100);

        decimal salarioTotal = salarioBase + ((salarioBase * percentual) * totalVendas);

        Console.WriteLine($"O salário total é de R$ {salarioTotal:F2}");
        Console.ReadKey();

    }
}
