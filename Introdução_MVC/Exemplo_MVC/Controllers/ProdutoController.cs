using exemplo_MVC.Models;
using exemplo_MVC.Views;

namespace exemplo_MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            produtoView.Listar(produtoModel.Ler());
        }

        public void Cadastrar()
        {
            produtoModel.Inserir(produtoView.CadastrarProduto());
        }
    }
}