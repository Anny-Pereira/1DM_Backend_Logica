using System;
namespace Exemplo_Lista.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }


        public Produto() { }

        public Produto(int respcodigo, string respnome, float resppreco)
        {
            this.Codigo = respcodigo;
            this.Nome = respnome;
            this.Preco = resppreco;
        }

    }
}