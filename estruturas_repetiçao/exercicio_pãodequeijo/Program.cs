using System;

namespace exercicio_pãodequeijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pacote = null;
            Console.WriteLine("Qual a quantidade de pacotes de pão de queijo na prateleira?");
            int Quantidade = int.Parse(Console.ReadLine());

            pacote = new int [Quantidade];
            int quantia = Quantidade - 1;

            for (var i = 0; i <= quantia; i++)
            {
                Console.WriteLine("Quantos pães de queijo há no pacote " + (i + 1) + "?");
                pacote [i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            float PreçoUnico = 1.5F; 
            foreach (var item in pacote)
            {
                Console.WriteLine("\nA quantidade de pães de queijo no pacote" + c + " é de " + item);
                float PreçoFinal = (PreçoUnico * pacote[(c - 1)]);
                Console.WriteLine("O preço total do pacote " + c + " é de R$ " + PreçoFinal);              
            c++;

            }

        }
    }
}
