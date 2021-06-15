using System;
using System.Collections.Generic;

namespace Exemplo_Objeto_como_Argumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        public List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
            Console.WriteLine("Produto removido la lista!");
        }

        public void AlterarProduto(int _codigo, Produto NovoProduto)
        {
            carrinho.Find(prod => prod.Codigo == _codigo).Nome = NovoProduto.Nome;
            carrinho.Find(prod => prod.Codigo == _codigo).Preco = NovoProduto.Preco;
            MostrarProdutos();
        }

        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (var p in carrinho)
                {
                    Console.WriteLine($@"
    ===============================================
    | Nome do produto: {p.Nome}
    | Preço do produto: {p.Preco}
                    ");
                }
                MostrarTotal();
            }
            else
            {
                Console.WriteLine("\nSeu carrinho está vazio!");
            }
        }

        public void MostrarTotal()
        {
            if (carrinho != null)
            {
                foreach (var pp in carrinho)
                {
                    ValorTotal += pp.Preco; 
                }
                Console.WriteLine($@"
    ===========================================            
    |   Valor total: {ValorTotal:C2}
    ===========================================            
                ");
            }
            else
            {
                Console.WriteLine("\nSeu carrinho está vazio!");
            }
        }



    }
}