using System;

namespace sistemas_produtos
{
    class Program
    {
        static string[] NomeProduto = new string[10];
        static float[] PreçoProduto = new float[10];
        static bool[] PromoçãoProduto = new bool[10];
        static int i = 0;
        static float acumuladora = 0;

        static void Main(string[] args)
        {
            string RespMenu;
            bool RepetirMenu = false;

            Console.WriteLine("Bem-vindo, consumidor!");
            do
            {
                Console.WriteLine("\nSelecione uma das opções (1, 2 ou 3):");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($@"
    ===========================
    | 1- Cadastrar produtos   |
    | 2- Listar produtos      |
    | 3- Imprimir total       |
    | 4- Sair                 |
    ===========================
            ");
                Console.ForegroundColor = ConsoleColor.White;
                RespMenu = Console.ReadLine();

                switch (RespMenu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Você pode cadastrar até 10 produtos.");
                        CadastrarProduto();
                        break;

                    case "2":
                        Console.Clear();
                        ListarProduto();
                        break;

                    case "3":
                        // Console.Clear();
                        ImprimirTotal();
                        break;

                    case "4":
                        RepetirMenu = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSessão finalizada. Obrigado por utilizar!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nNenhuma opção identificada. Tente novamente!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (!RepetirMenu);

        }

        static void CadastrarProduto()
        {
            string AdicionarProduto;

            do
            {
                Console.WriteLine("\nQual é o produto selecionado?");
                NomeProduto[i] = Console.ReadLine();

                Console.WriteLine("\nQual o preço do produto selecionado?");
                Console.Write("R$ ");
                PreçoProduto[i] = float.Parse(Console.ReadLine());
                acumuladora = acumuladora + PreçoProduto[i];

                Console.WriteLine("\nEste produto está em promoção (s-sim / n-não)?");
                string RespostaPromoção = Console.ReadLine();
                if (RespostaPromoção == "s")
                {
                    PromoçãoProduto[i] = true;
                }
                else if (RespostaPromoção == "n")
                {
                    PromoçãoProduto[i] = false;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVocê deseja cadastrar mais um produto (s-sim / n-não)?");
                Console.ForegroundColor = ConsoleColor.White;
                AdicionarProduto = Console.ReadLine();

                i++;
            } while (AdicionarProduto == "s");
        }

        static void ListarProduto()
        {
            for (var p = 0; p < i; p++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($@"
    =====================================================================
    | Produto:                      {NomeProduto[p]}
    | Preço:                        R$ {PreçoProduto[p]} 
    | Desconto:                     {(PromoçãoProduto[p] ? "Sim" : "Não")}
    =====================================================================
            ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void ImprimirTotal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($@"
    ================================
    |             TOTAL             |
    |===============================|
    |                               |
    |       R$ {acumuladora}          
    |                               |
    ================================
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
