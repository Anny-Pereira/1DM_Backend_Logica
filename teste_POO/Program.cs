using System;

namespace teste_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool JogarNovamente = false;

            personagem primeiroPersonagem = new personagem();

            primeiroPersonagem.pontoVida = 100;

            Console.Write("Qual o nome do primeiro personagem? ");
            primeiroPersonagem.nome = Console.ReadLine();

            Console.Write("Qual a idade do personagem? ");
            primeiroPersonagem.idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a habilidade do personagem? ");
            primeiroPersonagem.habilidade = Console.ReadLine();

            Console.WriteLine($"\nOs pontos de vida deste personagem é de {primeiroPersonagem.pontoVida}\n\n");


            personagem segundoPersonagem = new personagem();

            segundoPersonagem.pontoVida = 100;

            Console.Write("Qual o nome do segundo personagem? ");
            segundoPersonagem.nome = Console.ReadLine();

            Console.Write("Qual a idade do personagem? ");
            segundoPersonagem.idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a habilidade do personagem? ");
            segundoPersonagem.habilidade = Console.ReadLine();

            Console.WriteLine($"\nOs pontos de vida deste personagem é de {segundoPersonagem.pontoVida}\n\n");

            do
            {

                Console.WriteLine($"\nSelecione para {primeiroPersonagem.nome}:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($@"
    =====================
    | 1- Atacar         |
    | 2- Defender       |
    =====================
            ");
                Console.ForegroundColor = ConsoleColor.White;
                string opçãoPrimeiroPersonagem = Console.ReadLine();

                Console.WriteLine($"\nSelecione para {segundoPersonagem.nome}:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($@"
    =====================
    | 1- Atacar         |
    | 2- Defender       |
    =====================
            ");
                Console.ForegroundColor = ConsoleColor.White;
                string opçãoSegundoPersonagem = Console.ReadLine();

                if (opçãoPrimeiroPersonagem == "1" && opçãoSegundoPersonagem == "1")
                {
                    primeiroPersonagem.pontoVida = primeiroPersonagem.pontoVida - segundoPersonagem.Atacar();
                    segundoPersonagem.pontoVida = segundoPersonagem.pontoVida - primeiroPersonagem.Atacar();
                }
                else if (opçãoPrimeiroPersonagem == "1" && opçãoSegundoPersonagem == "2")
                {
                    segundoPersonagem.pontoVida = segundoPersonagem.pontoVida - (primeiroPersonagem.Atacar() - segundoPersonagem.Defender());
                }
                else if (opçãoPrimeiroPersonagem == "2" && opçãoSegundoPersonagem == "1")
                {
                    primeiroPersonagem.pontoVida = primeiroPersonagem.pontoVida - (segundoPersonagem.Atacar() - primeiroPersonagem.Defender());
                }
                else if (opçãoPrimeiroPersonagem == "2" && opçãoSegundoPersonagem == "2") { }

                Console.WriteLine($"Os pontos de vida do {primeiroPersonagem.nome} é de {primeiroPersonagem.pontoVida}");
                Console.WriteLine($"Os pontos de vida do {segundoPersonagem.nome} é de {segundoPersonagem.pontoVida}");

                Console.WriteLine($"\n\nDeseja jogar novamente (s-sim / n-não)?");
                string RespostaNovamente = Console.ReadLine();

                if (RespostaNovamente == "s")
                {
                    JogarNovamente = true;
                }
                else if (RespostaNovamente == "n")
                {
                    JogarNovamente = false;
                }

                if (primeiroPersonagem.pontoVida == 0 && segundoPersonagem.pontoVida == 0)
                {
                    JogarNovamente = false;
                }
            }
            while (JogarNovamente);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\nFIM DE JOGO!");
            Console.ForegroundColor = ConsoleColor.White;
        }
}
}
