using System;
using exemplo_MVC.Controllers;

namespace exemplo_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();

            produto.ListarProdutos();

            produto.Cadastrar();
        }
    }
}
