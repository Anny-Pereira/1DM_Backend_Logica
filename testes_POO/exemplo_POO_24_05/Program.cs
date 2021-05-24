using System;
using exemplo_POO_24_05.classes;


namespace exemplo_POO_24_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoInvalida = false;

            do
            {
            Console.WriteLine("\nOLÁ! Escolha dentre as opções de pagamento:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($@"
    ================================
    |   B - Boleto                 |
    |   C - Crédito                |
    |   D - Débito                 |
    |   X - Cancelar pagamento     |
    ================================
            ");
                Console.ForegroundColor = ConsoleColor.White;
                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        boleto b = new boleto();
                        b.Registrar();
                        opcaoInvalida = true;
                        break;

                    case "c":
                        credito c = new credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opcaoInvalida = true;
                        break;

                    case "d":
                        debito d = new debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opcaoInvalida = true;
                        break;

                    case "x":
                        pagamento p = new pagamento();
                        Console.WriteLine(p.Cancelar());
                        opcaoInvalida = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nForma de pagamento incompatível!");
                        Console.ForegroundColor = ConsoleColor.White;
                        opcaoInvalida = false;
                        break;
                }
            } 
            while (!opcaoInvalida);


        }
    }
}
