using System;

namespace passagens_aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string RespMenu;
            string[] Nome = new string[5];
            string[] Origem = new string[5];
            string[] Destino = new string[5];
            string[] DataVoo = new string[5];
            bool ValidaçãoSenha = false;
            int i = 0;
            string RespNovoRegistro;
            bool VoltarMenu = false;

            do
            {
                Console.WriteLine("Olá viajante! Para iniciar, insira uma senha de seis dígitos:");
                int Senha = int.Parse(Console.ReadLine());

                if (Senha == 123456)
                {
                    ValidaçãoSenha = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nLogin realizado com êxito!");
                    Console.ForegroundColor = ConsoleColor.White;

                    do
                    {
                        Console.WriteLine("\nEscolha uma das opções do menu (1, 2 ou 3):");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($@"
    =====================================
    | 1- Cadastrar passagem             |
    | 2- Listar passagens               |
    | 3- Sair                           |
    =====================================
                    ");
                        Console.ForegroundColor = ConsoleColor.White;
                        RespMenu = Console.ReadLine();

                        switch (RespMenu)
                        {
                            case "1":
                                Console.Clear();
                                Console.Write("\nCaro viajante, você pode registrar até 5 passagens, preenchendo os seguintes itens:\n");

                                do
                                {
                                    Console.Write("\nInsira o nome do passageiro: ");
                                    Nome[i] = Console.ReadLine();

                                    Console.Write("Insira sua origem: ");
                                    Origem[i] = Console.ReadLine();

                                    Console.Write("Insira seu destino: ");
                                    Destino[i] = Console.ReadLine();

                                    Console.Write("Insira a data do voo (00/00/00): ");
                                    DataVoo[i] = Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("\nRegistro realizado com sucesso!\n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("\nVocê deseja registrar uma nova passagem (s-sim / n-não)?");
                                    RespNovoRegistro = Console.ReadLine();

                                    i++;

                                } while (RespNovoRegistro == "s");
                                break;

                            case "2":
                                Console.Clear();
                                for (var p = 0; p < i; p++)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine($@"
    =======================================================
    | Nome do passageiro:       {Nome[p]}                 
    | Origem:                   {Origem[p]}               
    | Destino:                  {Destino[p]}              
    | Data do voo:              {DataVoo[p]}              
    =======================================================");
                                }
                                    Console.ForegroundColor = ConsoleColor.White;

                                break;

                            case "3":
                                VoltarMenu = true;
                                Console.WriteLine("Você saiu do sistema. Obrigado pela preferência!");
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNenhuma opção identificada!!!");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    } while (!VoltarMenu);


                }
                else
                {
                    ValidaçãoSenha = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSenha inválida. Tente novamente!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (ValidaçãoSenha == false);

        }
    }
}
