using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NotaFinal = false;

            do
            {
                Console.WriteLine("Insira uma nota de 0 a 10: ");   
                float Nota = float.Parse(Console.ReadLine());

                if (Nota <= 10)
                {
                    Console.WriteLine("Esta nota é válida!");
                    NotaFinal = true;
                }

                else
                {
                    Console.WriteLine("Esta nota é inválida. Insira outra nota: \n");
                }

            } 
            while (NotaFinal == false);
        }
    }
}
