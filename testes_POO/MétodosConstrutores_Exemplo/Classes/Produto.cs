namespace MétodosConstrutores_Exemplo.Classes
{
    public class Produto
    {
        public int Codigo = 1234;

        public string Nome = "Batata";

        public string Descrição = "Batata amarela e lavada";

        public int Estoque = 30;


        public Produto()
        {}

        public Produto(int RespEstoque)
        {
            Estoque = RespEstoque; 
        }

        public Produto(int RespCodigo, string RespNome, string RespDescrição, int RespostaEstoque)
        {
            Codigo = RespCodigo; 
            Nome = RespNome;
            Descrição = RespDescrição;
            Estoque = RespostaEstoque;
        }
    }
}