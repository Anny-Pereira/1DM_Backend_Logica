using System;

namespace função_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var OperaçãoNula = false;

            do
            {
                Console.WriteLine("Insira o primeiro número: ");
                double N1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o segundo número: ");
                double N2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira a operação você deseja fazer, sendo a(adição), s(subtração), m(multiplicação) e d(divisão): ");
                string operação = Console.ReadLine().ToLower();

                switch (operação)
                {
                    case "a":
                        Console.WriteLine($"O resultado da adição é: {adição(N1, N2)}");
                        OperaçãoNula = true;
                        break;

                    case "s":
                        Console.WriteLine($"O resultado da subtração é: {subtração(N1, N2)}");
                        OperaçãoNula = true;
                        break;

                    case "m":
                        Console.WriteLine($"O resultado da multiplicação é: {multiplicação(N1, N2)}");
                        OperaçãoNula = true;
                        break;

                    case "d":
                        Console.WriteLine($"O resultado da divisão é: {divisão(N1, N2)}");
                        OperaçãoNula = true;
                        break;


                    default:
                        Console.WriteLine("Nenhuma operação identificada. Insira os valores novamente.\n");
                        OperaçãoNula = false;
                        break;
                }
            } 
            while (OperaçãoNula == false);
            Console.WriteLine("");

        }

        static double adição(double N1, double N2)
        {
            return N1 + N2;
        }

        static double subtração(double N1, double N2)
        {
            return N1 - N2;
        }

        static double multiplicação(double N1, double N2)
        {
            return N1 * N2;
        }

        static double divisão(double N1, double N2)
        {
            return N1 / N2;
        }


    }
}
