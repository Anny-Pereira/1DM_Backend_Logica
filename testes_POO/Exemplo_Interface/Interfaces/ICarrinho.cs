using Exemplo_Interface.Classes;

namespace Exemplo_Interface.Interfaces
{
    public interface ICarrinho
    {
         void Cadastrar(Produto produto);
         
         void Listar();

         void Alterar(int _codigo, Produto produto);

         void Remover(Produto produto);
    }
}