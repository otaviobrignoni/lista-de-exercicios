namespace Exercicio08;

// 8. Crie um programa para verificar se um número é primo.

internal class Program
{
    static void Main()
    {
        Console.WriteLine("-+=Verificador de N° primo=+-");
        Console.Write("Digite um número inteiro -> ");

        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(VerificadorDePrimo(numero) ? "O número é primo" : "O número não é primo");
        Console.ReadKey();
    }

    static bool VerificadorDePrimo(int numero)
    {
        if (numero < 2) 
            return false;
        if (numero == 2) 
            return true;
        if (numero % 2 == 0) 
            return false;

        for (int i = 3; i * i <= numero; i += 2)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
}
