using System;
using POO_2505_sobrecarga.Classes;

namespace POO_2505_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            int RespIndice;
            string ItemBusca;

            Funcionario f = new Funcionario();

            for (var i = 1; i < f.Lista.Length; i++)
            {
                Console.Write("Insira um item da sua lista: ");
                f.Lista[i] = Console.ReadLine();

            }

            Console.WriteLine("\n\nMOSTRAR LISTA - SEM ARGUMENTO");
            f.Mostrar();

            Console.WriteLine("\nQual índice da lista você deseja mostrar (1-5)?");
            RespIndice = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nMOSTRAR LISTA - COM ARGUMENTO INT");
            f.Mostrar(RespIndice);

            Console.WriteLine("\nQual dos itens selecionados você procura?");
            ItemBusca = Console.ReadLine();

            Console.WriteLine("\n\nMOSTRAR LISTA - COM ARGUMENTO STRING");
            f.Mostrar(ItemBusca);


        }
    }
}
