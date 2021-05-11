using System;

namespace exercicio7_valores_inversos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            for (var i = 0; i < 15; i++)
            {
                Console.Write("Insira um número inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            for (var i = 14; i >= 0; i--)
            {
                Console.Write($"{numeros[i]}, ");
            }
        }
    }
}
