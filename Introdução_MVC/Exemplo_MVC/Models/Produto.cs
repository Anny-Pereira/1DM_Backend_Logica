using System.Collections.Generic;
using System.IO;

namespace exemplo_MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        private const string PATH = "DataBase/Produto.csv";


        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto produto = new Produto();

                produto.Codigo = int.Parse(atributos[0]);
                produto.Nome = atributos[1];
                produto.Preco = float.Parse(atributos[2]);

                produtos.Add(produto);
            }

            return produtos;
        }

        public string  PrepararLinha(Produto produto)
        {
            return $"{produto.Codigo};{produto.Nome};{produto.Preco}";
        }

        public void Inserir(Produto produto)
        {
            string[] linhas = {PrepararLinha(produto)};
            File.AppendAllLines(PATH, linhas);
        }
    }
}