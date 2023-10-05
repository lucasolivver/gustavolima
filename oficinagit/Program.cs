using System;
using System.Transactions;

class gitcurso
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num + num2;
        Console.WriteLine($"A soma dos números é {resultado}");
        Console.ReadKey();
    }
}