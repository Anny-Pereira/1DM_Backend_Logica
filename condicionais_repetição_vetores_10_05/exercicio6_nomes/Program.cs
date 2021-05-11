using System;

namespace exercicio6_nomes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] NomesGuardados = new string [10];

            for (var i = 0; i < 10; i++)
            {
            Console.Write($"Insira o nome {i + 1}, por favor: ");
            NomesGuardados[i] = Console.ReadLine().ToLower();

            }

            Console.Write("\nPor favor, insira um novo nome: ");
            string NovoNome = Console.ReadLine().ToLower();

            bool NomeEncontrado = false;

            foreach (var item in NomesGuardados)
            {
                if ( item == NovoNome)
                {
                    NomeEncontrado = true;
                }
            }

            if (NomeEncontrado)
            {
                Console.WriteLine("\nNome encontrado!");
            }

            else
            {
                Console.WriteLine("\nNome não encontrado...");
            }


            
        }
    }
}
