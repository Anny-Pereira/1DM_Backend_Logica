using System;

namespace exercicio3_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, consumidor!\nQual produto você adquiriu?");
            string Produto = Console.ReadLine();

            Console.WriteLine("\nQual o preço unitário do produto que você adquiriu?");
            double PreçoUnitário = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantas unidades do produto você adquiriu?");
            int Quantidade = int.Parse(Console.ReadLine());

            double Total = PreçoUnitário * Quantidade;

            if (Quantidade <= 5)
            { 
              double TotalDesconto = Total * 0.98;
              Console.WriteLine($"Seu total a pagar com um desconto de 2% é de R$: {TotalDesconto.ToString("N2")}");
            }

            else if (Quantidade > 5 && Quantidade >= 10)
            {
              double TotalDesconto = Total * 0.97;
              Console.WriteLine($"Seu total a pagar com um desconto de 3% é de R$: {TotalDesconto.ToString("N2")}");
            }

            else if (Quantidade > 10)
            {
              double TotalDesconto = Total * 0.95;
              Console.WriteLine($"Seu total a pagar com um desconto de 5% é de R$: {TotalDesconto.ToString("N2")}");
            }



        }


    }
}
