using System;
using ClassesEstáticasExemplo.Classes;

namespace ClassesEstáticasExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa iniciado!\n");

            Console.Write("Insira um valor em R$: ");
            float ValorRS = float.Parse(Console.ReadLine());

            Console.WriteLine($"Esta quantia equivale a U$: {Conversor.RealPDolar(ValorRS).ToString("N2")}");


            Console.Write("\nInsira um valor em U$: ");
            float ValorUS = float.Parse(Console.ReadLine());

            Console.WriteLine($"Esta quantia equivale a R$: {Conversor.DolarPReal(ValorUS)}");
        }
    }
}
