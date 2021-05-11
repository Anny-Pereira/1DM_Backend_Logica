using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Idade();
            int retornoIdade = Idade();
            Condição(retornoIdade);
         

           
        }

        static int Idade()
        {
            Console.WriteLine("Olá, cidadão! Por favor, insira seu ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());

            int AnoAtual = DateTime.Now.Year;
            int Idade = AnoAtual - anoNasc;
            return Idade;
        }

        static void Condição(int Idade)
        {

            if (Idade >= 18)
            {
                Console.WriteLine("\nVocê já pode e deve votar cidadão!");
            }
            
            else if (Idade >= 16 && Idade <18 )
            {
                Console.WriteLine("\nSeu voto é alternativo, jovem!");
            }

            // else (Idade < 16);
            else
            {
                Console.WriteLine("\nVocê ainda não pode votar!");
            }
        }
    }
}
