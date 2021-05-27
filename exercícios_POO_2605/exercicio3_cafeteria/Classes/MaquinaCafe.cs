using System;

namespace exercicio3_cafeteria.Classes
{
    public class MaquinaCafe
    {
        // em gramas
        private int AcucarDisponivel = 1000;

        private int PorcaoPadraoAcucar = 10;

        public int AcucarAtual { get; set; }

        public void FazerCafe()
        {
            AcucarAtual = AcucarDisponivel - PorcaoPadraoAcucar;
            AcucarDisponivel = AcucarAtual;
            if (AcucarAtual <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"
                Não será possível preparar o café com 10g de açúcar.
                É necessário reabastecer a máquina!
                ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (AcucarAtual <= AcucarDisponivel)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ainda restam {AcucarAtual}g de açúcar na máquina");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nPreparando café com 10g de açúcar...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("\nA produção do cafézinho não é compatível para com esta quantidade de açúcar.");
            }

        }

        public void FazerCafe(int EscolhaAcucar)
        {
            AcucarAtual = AcucarDisponivel - EscolhaAcucar;
            AcucarDisponivel = AcucarAtual;

            if (EscolhaAcucar <= AcucarDisponivel)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ainda restam {AcucarDisponivel}g de açúcar na máquina");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"\nPreparando café com {EscolhaAcucar}g de açúcar...");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else if (EscolhaAcucar > AcucarDisponivel)
            {
                Console.WriteLine("\nA produção do cafézinho não é compatível para com esta quantidade de açúcar.");
            }

        }
        public string FazerCafeSA()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return "\nPreparando café sem açúcar...";
        }

    }
}