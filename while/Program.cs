// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Console.Write("Digite um numero: ");
double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

while (x >= 0.00)
{
    double raiz = Math.Sqrt(x);
    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
    Console.Write("Digite um numero: ");
    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.WriteLine("Numero negativo!!");



