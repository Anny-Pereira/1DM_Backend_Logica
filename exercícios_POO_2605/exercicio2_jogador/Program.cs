using System;
using exercicio2_jogador.Classes;

namespace exercicio2_jogador
{
    class Program
    {
        static void Main(string[] args)
        {

            string ResPosição;
            bool RepetMenu = false;
            string SN;

            do
            {
                Console.WriteLine($@"
    Para verificar o estado de aposentadoiria do jogador, insira a sua posição:
    1- Defesa
    2- Ataque
    3- Meio-Campo
            ");

                ResPosição = Console.ReadLine();

                switch (ResPosição)
                {
                    case "1":
                        RepetMenu = true;
                        JogadorDefesa JD = new JogadorDefesa();
                        JD.Imprimir();
                        JD.Aposentadoria();

                        Console.WriteLine("\nDeseja imprimir as informações (s-sim / n-não)?");
                        SN = Console.ReadLine().ToLower();
                        if (SN == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSessão finalizada. Obrigada por utilizar!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (SN == "s")
                        {
                            JD.Impressão();
                        }
                        break;

                    case "2":
                        RepetMenu = true;
                        JogadorAtaque JA = new JogadorAtaque();
                        JA.Imprimir();
                        JA.Aposentadoria();

                        Console.WriteLine("\nDeseja imprimir as informações (s-sim / n-não)?");
                        SN = Console.ReadLine().ToLower();
                        if (SN == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSessão finalizada. Obrigada por utilizar!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (SN == "s")
                        {
                            JA.Impressão();
                        }
                        break;

                    case "3":
                        RepetMenu = true;
                        JogadorMeioCampo JM = new JogadorMeioCampo();
                        JM.Imprimir();
                        JM.Aposentadoria();

                        Console.WriteLine("\nDeseja imprimir as informações (s-sim / n-não)?");
                        SN = Console.ReadLine().ToLower();
                        if (SN == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSessão finalizada. Obrigada por utilizar!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (SN == "s")
                        {
                            JM.Impressão();
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nenhuma opção identificada. Tente novamente!");
                        Console.ForegroundColor = ConsoleColor.White;
                        RepetMenu = false;
                        break;
                }
            } while (!RepetMenu);

        }
    }
}
