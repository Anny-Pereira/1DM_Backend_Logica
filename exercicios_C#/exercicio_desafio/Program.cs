using System;

namespace exercicio_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string Resposta = "";

            do 
            {

                Console.WriteLine("Olá nadador(a)! Qual a sua idade?");
                int IdadeNadador = int.Parse(Console.ReadLine());

                if (IdadeNadador >= 5 && IdadeNadador <= 7)
                {
                    Console.WriteLine("\nDe acordo com a sua idade, sua categoria é: INFANTIL A");
                }

                else if (IdadeNadador < 5)
                {
                    Console.WriteLine("\nVocê não possui categoria...");
                }

                else if (IdadeNadador >= 8 && IdadeNadador <= 10)
                {
                    Console.WriteLine("\nDe acordo com a sua idade, sua categoria é: INFANTIL B");
                }

                else if (IdadeNadador >= 11 && IdadeNadador <= 13)
                {
                    Console.WriteLine("\nDe acordo com a sua idade, sua categoria é: JUVENIL A");
                }

                else if (IdadeNadador >= 14 && IdadeNadador <= 17)
                {
                    Console.WriteLine("\nDe acordo com a sua idade, sua categoria é: JUVENIL B");
                }

                if (IdadeNadador >= 18)
                {
                    Console.WriteLine("\nDe acordo com a sua idade, você não possui categoria. \nInsira outra idade, caso contrário sairá do sistema.\n");
                }

            Console.WriteLine("Você deseja continuar no sistema?\nSim ou não?");
            Resposta = Console.ReadLine().ToLower();


            } 

            while (Resposta == "sim");
            Console.WriteLine("\nSessão finalizada. Você saiu do sistema!");


        }
    }
}
