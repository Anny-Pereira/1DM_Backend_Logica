using System;
using exercicio3_cafeteria.Classes;

namespace exercicio3_cafeteria
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe M = new MaquinaCafe();

            string EscolhaMenu;
            bool RepetirMenu = false;
            int EscolhaAcucar;

            Console.WriteLine("Seja bem-vindo(a)!");

            while (!RepetirMenu)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($@"
    =========================================
    |       ESCOLHA DENTRE AS OPÇÕES:       |
    -----------------------------------------
    | 1- Café com açúcar                    |
    | 2- Café com açúcar personalizado      |              
    | 3- Café sem açúcar                    |
    | 4- Finalizar                          |
    =========================================
            ");
                Console.ForegroundColor = ConsoleColor.White;
                EscolhaMenu = Console.ReadLine();

                switch (EscolhaMenu)
                {
                    case "1":
                        RepetirMenu = false;
                        M.FazerCafe();
                        break;

                    case "2":
                        RepetirMenu = false;
                        Console.WriteLine("Qual a quantidade de açúcar que você deseja (gramas)?");
                        EscolhaAcucar = int.Parse(Console.ReadLine());
                        M.FazerCafe(EscolhaAcucar);
                        break;

                    case "3":
                        RepetirMenu = false;
                        Console.WriteLine(M.FazerCafeSA());
                        break;

                    case "4":
                        RepetirMenu = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nProcesso finalizado. Obrigado pela preferência!!");
                        break;

                    default:
                        RepetirMenu = false;
                        Console.WriteLine("\nNenhuma opção identificada. Tente novamente!");
                        break;
                }
            }



        }
    }
}
