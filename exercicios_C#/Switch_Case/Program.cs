using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Na pesquisa de hoje, vamos selecionar pessoas em turmas de acordo com a inicial de seus nomes.");
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            string inicial = nome.Substring(0, 1).ToLower();

            switch (inicial)
            {
                case "a":
                Console.WriteLine("\nDe acordo com a sua inicial: " + inicial + ", você está na turma 1.");
                    break;

                case "e":
                Console.WriteLine("\nDe acordo com a sua inicial: " + inicial + ", você está na turma 2.");
                    break;

                case "i":
                Console.WriteLine("\nDe acordo com a sua inicial: " + inicial + ", você está na turma 3.");
                    break;

                case "o":
                Console.WriteLine("\nDe acordo com a sua inicial: " + inicial + ", você está na turma 4.");
                    break;

                case "u":
                Console.WriteLine("\nDe acordo com a sua inicial: " + inicial + ", você está na turma 5.");
                    break;

                default:
                Console.WriteLine("\nDe acordo com a sua inicial: " + inicial + ", você não possui turma definida.");
                    break;
            }
            

        }
    }
}
