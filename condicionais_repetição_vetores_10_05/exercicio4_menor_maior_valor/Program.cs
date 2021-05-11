using System;

namespace exercicio4_menor_maior_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int [10];

            for (int i = 0; i <valores.Length; i++)
            {
                Console.Write("Insira um número: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);

            Console.WriteLine($"\n\nO menor número é: {valores[0]}");
            Console.WriteLine($"\nO maior número é: {valores[9]}");


        }
    }
}
