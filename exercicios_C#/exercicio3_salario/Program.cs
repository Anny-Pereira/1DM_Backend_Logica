using System;

namespace exercicio3_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo(a)! Qual o seu salário?");
            float Salario = float.Parse(Console.ReadLine());

            if (Salario < 500)
            {
                var AumentoSalario = (Salario * 1.3).ToString("N2");
                // 1,3 é o inteiro somado ao aumento
                Console.WriteLine("\nVocê recebeu um aumento de 30% e agora seu salário equivale à " + AumentoSalario + " reais!");
            }

            else
            {
                Console.WriteLine("\nSeu salário não foi alterado!");              
            }

        }
    }
}
