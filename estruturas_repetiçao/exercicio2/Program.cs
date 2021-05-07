using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
             bool Igualdade = false;

            do
            {
                Console.WriteLine("Insira seu nome de usuário: ");
                string Usuário = Console.ReadLine();

                Console.WriteLine("Insira sua senha: ");
                string Senha = Console.ReadLine();

                if (Usuário != Senha)
                {
                    Console.WriteLine("\nProcesso efetuado com sucesso!");
                    Igualdade = true;
                }
                else
                {
                    Console.WriteLine("\nErro! Seu nome de usuário NÃO pode ser igual a sua senha. Efetue o login novamente.\n");
                }
                
            } 
            while (Igualdade == false);
        }
    }
}
