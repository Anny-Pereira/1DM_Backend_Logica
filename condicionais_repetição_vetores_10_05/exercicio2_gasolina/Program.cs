using System;

namespace exercicio2_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Opções();
        }

        static void Opções()
        {

            bool RespValida = false;
            do
            {
                Console.WriteLine("Aoa! Com qual combustível você irá abastecer (A(Álcool), G(Gasolina))?");
                string Combustível = Console.ReadLine().ToLower();

                switch (Combustível)
                {
                    case "a":
                    Console.WriteLine("Quantos litros você deseja abastecer?");
                    double LitrosDesejados = double.Parse(Console.ReadLine());

                    if (LitrosDesejados <= 20)
                    {
                        double PreçoLitro = 4.90 * 0.97;
                        double Total = (PreçoLitro * LitrosDesejados);
                        Console.WriteLine($"\nO seu total a pagar com um desconto de 3% no litro é de R$: {Total.ToString("N2")}");
                    }
                    else if (LitrosDesejados > 20)
                    {
                        double PreçoLitro = 4.90 * 0.95;
                        double Total = PreçoLitro * LitrosDesejados;
                        Console.WriteLine($"\nO seu total a pagar com um desconto de 5% no litro é de R$: {Total.ToString("N2")}");
                    }

                    RespValida = true;
                        break;


                    case "g":
                    Console.WriteLine("Quantos litros você deseja abastecer?");
                    double LitrosColocados = double.Parse(Console.ReadLine());

                    if (LitrosColocados <= 20)
                    {
                        double PreçoLitro = 5.30 * 0.96;
                        double Total = (PreçoLitro * LitrosColocados);
                        Console.WriteLine($"\nO seu total a pagar com um desconto de 4% no litro é de R$: {Total.ToString("N2")}");
                    }
                    else if (LitrosColocados > 20)
                    {
                        double PreçoLitro = 5.30 * 0.94;
                        double Total = (PreçoLitro * LitrosColocados);
                        Console.WriteLine($"\nO seu total a pagar com um desconto de 6% no litro é der R$: {Total.ToString("N2")}");

                    }
                    RespValida = true;
                        break;

                    default:
                    Console.WriteLine("\nSua resposta é inválida. Tente novamente.");
                    RespValida = false;
                        break;
                }
            }
            while (RespValida == false);
        }
        
    }
}
