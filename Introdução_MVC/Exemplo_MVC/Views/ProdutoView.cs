using System;
using System.Collections.Generic;
using exemplo_MVC.Models;

namespace exemplo_MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C2}");
            }
        }

        public Produto CadastrarProduto()
        {
            Produto Prod = new Produto();

            Console.Write("\nInsira o código do produto: ");
            Prod.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Insira o nome do produto: ");
            Prod.Nome = Console.ReadLine();

            Console.Write("Insira o preço do produto: ");
            Prod.Preco = float.Parse(Console.ReadLine());

            return Prod;
        }
    }
}