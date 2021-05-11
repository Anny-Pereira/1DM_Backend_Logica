using System;

namespace exercicio7_valores_inversos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (var i = 1; i <= 10; i++)
            {
                Console.Write("Insira um número inteiro: ");
                int NInserido = int.Parse(Console.ReadLine());
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(numeros);
            }
            



        }
    }
}
