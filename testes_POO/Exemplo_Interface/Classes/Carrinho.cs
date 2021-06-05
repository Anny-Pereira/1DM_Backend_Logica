using System;
using System.Collections.Generic;
using Exemplo_Interface.Interfaces;

namespace Exemplo_Interface.Classes
{
    public class Carrinho : Produto, ICarrinho
    {
        public float ValorTotal {get; set;}

        List<Produto> carrinho = new List<Produto>();

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(item => item.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(item => item.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Listar()
        {
            foreach (var item in carrinho)
            {
                Console.WriteLine($"Nome do produto: {item.Nome} \nPreço do produto: {item.Preco:C2}");
            }
        }

        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }
    }
}