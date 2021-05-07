using System;

namespace teste_NotaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual sua primeira nota? ");
            float SuaNota1 = float.Parse(Console.ReadLine ());
            Console.Write("Qual sua segunda nota? ");
            float SuaNota2 = float.Parse(Console.ReadLine ());
            Console.Write("Qual sua terceira nota? ");
            float SuaNota3 = float.Parse(Console.ReadLine());

            float SomaNotas = (SuaNota1 + SuaNota2 + SuaNota3);

            float NotaMedia = ((SomaNotas) / 3);
            Console.WriteLine ( "\n" + nome + "," + " sua nota média é de: "+ NotaMedia.ToString("N2") + "\n");

            if (NotaMedia > 5)
            {
                Console.WriteLine("Parabéns! Você foi aprovado!");
            }

            else
            {
                Console.WriteLine("Ih! Estude mais... Você foi reprovado!");
            }
        }
    }
}
