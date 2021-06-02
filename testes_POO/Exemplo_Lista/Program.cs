using System;
using System.Collections.Generic;
using Exemplo_Lista.Classes;

namespace Exemplo_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            // int respcodigo;
            string respnome;
            float resppreco;
            string RespRemove;
            string RespAltera;
            string ProdutoRemovido;
            string ProdutoAlterado;

            List<Produto> Produto = new List<Produto>();

            Console.WriteLine("Olá usuário! Quantos produtos você deseja cadastrar?");
            int QuantProd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= QuantProd; i++)
            {
                // Console.Write($"\nInsira o código do produto {i}: ");
                // respcodigo = int.Parse(Console.ReadLine());
                Console.Write($"Insira o nome do produto {i}: ");
                respnome = Console.ReadLine().ToLower();
                Console.Write($"Insira o preço do produto {i}: R$ ");
                resppreco = float.Parse(Console.ReadLine());


                Produto.Add(new Produto(i, respnome, resppreco));
            }


            foreach (var item in Produto)
            {
                Console.WriteLine($@"
    Código: {item.Codigo}            
    Produto: {item.Nome}
    Preço R$: {item.Preco}
                ");
            }

            Console.WriteLine("Você deseja excluir algum produto? (s-sim / n-não)");
            RespRemove = Console.ReadLine().ToLower();

            if (RespRemove == "s")
            {
                Console.WriteLine("Qual produto deseja remover?");
                ProdutoRemovido = Console.ReadLine().ToLower();

                Produto.RemoveAll(Produto => Produto.Nome == ProdutoRemovido);
                Console.WriteLine("\nProduto removido!\n");

                foreach (var item in Produto)
                {
                    Console.WriteLine($@"
    Código: {item.Codigo}            
    Produto: {item.Nome}
    Preço R$: {item.Preco}
                    ");
                }
            }

            else
            {
                Console.WriteLine("\nObrigado por utilizar!\n");
            }

            Console.WriteLine("Você deseja alterar algum produto? (s-sim / n-não)");
            RespAltera = Console.ReadLine().ToLower();

            if (RespAltera == "s")
            {
                            Console.WriteLine("Qual produto deseja alterar?");
                            ProdutoAlterado = Console.ReadLine().ToLower();

                            Console.Write($"Insira o nome do produto: ");
                            respnome = Console.ReadLine();
                            Console.Write($"Insira o preço do produto: R$ ");
                            resppreco = float.Parse(Console.ReadLine());


                            int CodigoEncotrado = Produto.Find(item => item.Nome == ProdutoAlterado).Codigo;
                            Produto.Find(item => item.Codigo == CodigoEncotrado).Preco = resppreco;
                            Produto.Find(item => item.Codigo == CodigoEncotrado).Nome = respnome;


                            foreach (var item in Produto)
                            {
                                Console.WriteLine($@"
                Código: {item.Codigo}            
                Produto: {item.Nome}
                Preço R$: {item.Preco}
                            ");
                            }


            }
            else
            {
                Console.WriteLine("Obrigado por utilizar!");
            }


        }


    }
}
