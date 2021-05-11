using System;

namespace exercicio6_nomes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] NomesGuardados = new string [10];

            for (var i = 1; i <= 10; i++)
            {
            Console.Write("Insira um nome, por favor: ");
            string Nomes = Console.ReadLine().ToLower();

            }

            Console.Write("Por favor, insira um novo nome: ");
            string NovoNome = Console.ReadLine();

            foreach (var item in NomesGuardados)
            {
                if ( item == NovoNome)
                {
                    Console.WriteLine("Nome encontrado!");
                }
                else
                {
                    Console.WriteLine("Nome não encontrado...");
                }
            }


            
        }
    }
}
