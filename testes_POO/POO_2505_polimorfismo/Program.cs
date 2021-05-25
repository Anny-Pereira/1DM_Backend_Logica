using System;
using POO_2505_polimorfismo.Classes;

namespace POO_2505_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMen m = new MegaMen();

            Console.WriteLine(m.Correr());
            Console.WriteLine(m.Pular());

            Zero z = new Zero();
            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());

        }
    }
}
