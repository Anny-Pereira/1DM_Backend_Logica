using System;

namespace exercicio2_jogador.Classes
{
    public abstract class Jogador
    {
        public string Nome { get; set; }
        public int AnoNasc { get; set; }
        public string Nacion { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public int AnoAtual = DateTime.Now.Year;

        public bool aposen;


        public void Imprimir()
        {
            Console.Write("Insira o nome do jogador: ");
            Nome = Console.ReadLine();

            Console.Write("Insira o ano de nascimento do jogador (xxxx): ");
            AnoNasc = int.Parse(Console.ReadLine());

            Console.Write("Insira a nacionalidade do jogador: ");
            Nacion = Console.ReadLine();

            Console.Write("Insira a altura do jogador (metros): ");
            Altura = Console.ReadLine();

            Console.Write("Insira o peso do jogador (kg): ");
            Peso = Console.ReadLine();
        }

        public int Idade()
        {
            return (AnoAtual - AnoNasc);
        }

        public void Impressão()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($@"
    =================================================
    | Nome:                     {Nome}            
    | Ano de Nascimento:        {AnoNasc}
    | Nacionalidade:            {Nacion}
    | Altura:                   {Altura} m
    | Peso:                     {Peso} kg
    | Estado:                   {(aposen ? "Aposentado" : "Não Aposentado")}
    =================================================
            ");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}