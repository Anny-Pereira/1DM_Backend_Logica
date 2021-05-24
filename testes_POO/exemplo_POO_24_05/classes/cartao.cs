using System;

namespace exemplo_POO_24_05.classes
{
    public abstract class cartao : pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string CVV;

        public string SalvarCartao()
        {
            Console.WriteLine("\nInsira a bandeira do cartão:");
            Bandeira = Console.ReadLine();

            Console.WriteLine("\nInsira o número do cartão:");
            Numero = Console.ReadLine();
            
            Console.WriteLine("\nInsira o titular do cartão:");
            Titular = Console.ReadLine();

            Console.WriteLine("\nInsira o CVV do seu cartão:");
            CVV = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            return ($"\nO cartão de número {Numero} foi salvo com sucesso!");
        }
    }
}