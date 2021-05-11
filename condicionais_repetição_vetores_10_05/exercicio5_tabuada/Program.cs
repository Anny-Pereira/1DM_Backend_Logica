using System;

namespace exercicio5_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {        


            int[] N2 = new int [10];
            for (var i = 1; i <= 10; i++)
            {
            Console.WriteLine($"\n\nTabuada do {i}");
                for (var p = 0; p <= 10; p++)
                {
                Console.WriteLine(i + " x " + p + " = " + (i * p));
                }
            }



        }
        
    }
}

