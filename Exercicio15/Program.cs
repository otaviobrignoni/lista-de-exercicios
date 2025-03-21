﻿
namespace Exercicio15;

//15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura)². Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
//  ● IMC em adultos Condição
//  ● Abaixo de 18,5
//  ● Abaixo do peso
//  ● Entre 18,5 e 25 Peso normal
//  ● Entre 25 e 30
//  ● Acima do peso
//  ● Acima de 30 obeso

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-+=Calculadora de IMC de adultos=+-");
        Console.Write("Digite a sua altura ->");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o seu peso ->");
        double peso = Convert.ToDouble(Console.ReadLine());
        double imc = peso / Math.Pow(altura, 2);
        if (imc <= 18.5)
            Console.WriteLine($"Abaixo do peso normal. IMC = {imc:F2}");
        else if (imc > 18.5 && imc <= 25)
            Console.WriteLine($"Peso normal. IMC = {imc:F2}");
        else if (imc > 25 && imc <= 30)
            Console.WriteLine($"Acima do peso normal. IMC = {imc:F2}");
        else
            Console.WriteLine($"Obeso. IMC = {imc:F2}");
        Console.ReadKey();
    }
}
