namespace Exercicio10;

//10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.Cada
//pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
//venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
//Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
//quantidades de pães e de broas, e depois calcular os dados solicitados.

internal class Program
{
    const decimal valorPao = 0.12m;
    const decimal valorBroa = 1.50m;
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora padaria Hotpão=+-");
        Console.Write("Digite a quantidade de pães vendidos -> ");
        int quantidadePaes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quantidade de broas vendidas -> ");
        int quantidadeBroas = Convert.ToInt32(Console.ReadLine());
        decimal totalValorVendas = (quantidadePaes * valorPao) + (quantidadeBroas * valorBroa);
        decimal poupança = totalValorVendas * 0.1m;
        Console.WriteLine($"Valor das vendas: Pães: R${(quantidadePaes * valorPao):F2} Broas: R${(quantidadeBroas * valorBroa):F2}\nTotal: R${totalValorVendas:F2}\nPoupança: R${poupança:F2}");
        Console.ReadKey();
    }
}
