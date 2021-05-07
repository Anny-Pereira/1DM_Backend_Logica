using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ValNome = false;
            do
            {
                Console.WriteLine("Campo obrigatório*\nInsira um nome diferente de vazio: ");
                string Nome = Console.ReadLine();
                if (Nome != "")
                {
                    ValNome = true;
                }
                else 
                {
                    Console.WriteLine("Nenhum dado identificado. Insira seu nome: ");
                }
                
            } 
            while (ValNome == false);


            bool ValIdade = false;
            do
            {
                Console.WriteLine("\nCampo obrigatório*\nInsira sua idade: ");
                int Idade = int.Parse(Console.ReadLine());
                if (Idade <= 150 && Idade > 0)
                {
                    ValIdade = true;
                }
                else 
                {
                    Console.WriteLine("Nenhum dado identificado. Insira sua idade: ");
                }
                
            } 
            while (ValIdade == false);


            bool ValSalario = false;
            do
            {
                Console.WriteLine("\nCampo obrigatório*\nInsira o valor de seu salário: ");
                int Salario = int.Parse(Console.ReadLine());
                if (Salario > 0)
                {
                    ValSalario = true;
                }
                else 
                {
                    Console.WriteLine("Nenhum dado identificado. Insira o valor de seu salário: ");
                }
                
            } 
            while (ValSalario == false);


            bool ValEstado = false;
            do
            {
                Console.WriteLine("\nCampo obrigatório*\nInsira o seu Estado Civil (s(solteiro); c(casado); v(viúvo); d(divorciado)): ");
                string Estado = Console.ReadLine().ToLower();
              
                switch (Estado)
                {
                    case "s":
                    Console.WriteLine("Você é solteiro(a).\n\nProcesso efetuado com sucesso!");
                    ValEstado = true;
                        break;

                    case "c":
                    Console.WriteLine("Você é casado(a).\n\nProcesso efetuado com sucesso!");
                    ValEstado = true;
                        break;

                    case "v":
                    Console.WriteLine("Você é viúvo(a).\n\nProcesso efetuado com sucesso!");
                    ValEstado = true;
                        break;

                    case "d":
                    Console.WriteLine("Você é divorciado(a).\n\nProcesso efetuado com sucesso!");
                    ValEstado = true;
                        break;


                    default:
                    Console.WriteLine("Nenhum dado identificado. Insira seu Estado Civil: ");
                        break;
                }
                
                
            } 
            while (ValEstado == false);
        }
    }
}
