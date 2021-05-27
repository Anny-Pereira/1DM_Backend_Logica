using System;

namespace exercicio2_jogador.Classes
{
    public class JogadorDefesa : Jogador
    {
        private int IdadeAposentadoria = 40;

        public void Aposentadoria()
        {
            if (Idade() >= IdadeAposentadoria)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"\nO jogador tem {Idade()} anos e já pode se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
                aposen = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nNesta classificação, o jogador não pode se aposentar, pois ainda tem {Idade()} anos.");
                Console.ForegroundColor = ConsoleColor.White;
                aposen = false;
            }
        }

    }
}