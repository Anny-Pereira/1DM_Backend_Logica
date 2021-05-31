using System;
using MétodosConstrutores_Exemplo.Classes;

namespace MétodosConstrutores_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Programa iniciado!\n ");

            Produto P = new Produto();
            Console.WriteLine($@"
            PRODUTO 1
            Código: {P.Codigo}
            Nome: {P.Nome}
            Descrição: {P.Descrição}
            Estoque: {P.Estoque}
            ");


            Console.Write("\nInsira uma nova quantidade do estoque: ");
            int RespEstoque = int.Parse(Console.ReadLine());

            Produto P2 = new Produto(RespEstoque);
            Console.WriteLine($@"
            PRODUTO 2
            Código: {P2.Codigo}
            Nome: {P2.Nome}
            Descrição: {P2.Descrição}
            Estoque: {P2.Estoque}
            ");


            Console.Write("\nInsira o código do produto: ");
            int RespCodigo = int.Parse(Console.ReadLine());
            Console.Write("\nInsira o nome do produto: ");
            string RespNome = Console.ReadLine();
            Console.Write("\nInsira a descrição do produto: ");
            string RespDescrição = Console.ReadLine();
            Console.Write("\nInsira a quantidade do estoque: ");
            int RespostaEstoque = int.Parse(Console.ReadLine());

            Produto P3 = new Produto(RespCodigo, RespNome, RespDescrição, RespostaEstoque);
            Console.WriteLine($@"
            PRODUTO 3
            Código: {P3.Codigo}
            Nome: {P3.Nome}
            Descrição: {P3.Descrição}
            Estoque: {P3.Estoque}
            ");

            Produto L = new Produto();
        }
    }
}
