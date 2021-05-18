using System;

namespace teste_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            personagem primeiroPersonagem = new personagem();

            primeiroPersonagem.pontoVida = 100;

            Console.Write("Qual o nome do primeiro personagem? ");
            primeiroPersonagem.nome = Console.ReadLine();

            Console.Write("Qual a idade do personagem? ");
            primeiroPersonagem.idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a habilidade do personagem? ");
            primeiroPersonagem.habilidade = Console.ReadLine();

            Console.WriteLine($"Os pontos de vida deste personagem é de {primeiroPersonagem.pontoVida}");


            personagem segundoPersonagem = new personagem();

            segundoPersonagem.pontoVida = 100;

            Console.Write("Qual o nome do segundo personagem? ");
            segundoPersonagem.nome = Console.ReadLine();

            Console.Write("Qual a idade do personagem? ");
            segundoPersonagem.idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a habilidade do personagem? ");
            segundoPersonagem.habilidade = Console.ReadLine();

            Console.WriteLine($"Os pontos de vida deste personagem é de {segundoPersonagem.pontoVida}");

            Console.WriteLine("\nSelecione dentre as opções:\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($@"
    =====================
    | 1- Atacar         |
    | 2- Defender       |
    =====================
            ");
            Console.ForegroundColor = ConsoleColor.White;
            string opçãoPrimeiroPersonagem = Console.ReadLine();

            Console.WriteLine("\nSelecione dentre as opções:\n");
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
                segundoPersonagem.pontoVida = segundoPersonagem.pontoVida - (segundoPersonagem.Atacar() - primeiroPersonagem.Defender());
            }
            else if (opçãoPrimeiroPersonagem == "2" && opçãoSegundoPersonagem == "1")
            {
                primeiroPersonagem.pontoVida = primeiroPersonagem.pontoVida - (primeiroPersonagem.Atacar() - segundoPersonagem.Defender());
            }
            else if (opçãoPrimeiroPersonagem == "2" && opçãoSegundoPersonagem == "2") {}

            Console.WriteLine($"Os pontos de vida do {primeiroPersonagem.nome} é de {primeiroPersonagem.pontoVida}");
            Console.WriteLine($"Os pontos de vida do {segundoPersonagem.nome} é de {segundoPersonagem.pontoVida}");

        }
    }
}
