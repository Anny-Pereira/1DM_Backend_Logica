using System;

namespace exercicio2_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu ano de nascimento? ");
            int AnoNascimento = int.Parse(Console.ReadLine());

            int AnoAtual = DateTime.Now.Year;
            int Idade = (AnoAtual - AnoNascimento);

            Console.WriteLine("\nVocê tem aproximadamente " + Idade + " anos!");

            // 1 ano tem 52 semanas 
            int IdadeSemanas = Idade * 52;
            Console.WriteLine("Sua idade em semanas é de aproximadamente: " + IdadeSemanas + " semanas!");

        }
    }
}
