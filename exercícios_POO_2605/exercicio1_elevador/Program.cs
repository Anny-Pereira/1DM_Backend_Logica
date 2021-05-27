using System;
using exercicio1_elevador.Classes;

namespace exercicio1_elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            string RespElevador;
            bool RepetInicial = false;
            string OpçãoMenu;
            bool RepetirMenu = true;

            do
            {
                Console.WriteLine("Olá! Qual elevador será utilizado (s-social / e-serviço)?");
                RespElevador = Console.ReadLine().ToLower();

                if (RespElevador == "s")
                {
                    RepetInicial = true;
                    ElevadorSocial Soc = new ElevadorSocial();
                    Soc.Inicializar();

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($@"
    =============================
    |   SELECIONE UMA OPÇÃO:    |
    ----------------------------- 
    | 1- Entrar                 |
    | 2- Sair                   |
    | 3- Subir                  |
    | 4- Descer                 | 
    | 5- Finalizar              |        
    =============================
                    ");
                        Console.ForegroundColor = ConsoleColor.White;
                        OpçãoMenu = Console.ReadLine();

                        switch (OpçãoMenu)
                        {
                            case "1":
                                RepetirMenu = true;
                                Soc.Entrar();
                                break;

                            case "2":
                                Soc.Sair();
                                RepetirMenu = true;
                                break;

                            case "3":
                                Soc.Subir();
                                RepetirMenu = true;
                                break;

                            case "4":
                                Soc.Descer();
                                RepetirMenu = true;
                                break;

                            case "5":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nPrograma finalizado!");
                                Console.ForegroundColor = ConsoleColor.White;
                                RepetirMenu = false;

                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nNenhuma opção identificada. Tente nnovamente!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                RepetirMenu = true;
                                break;
                        }

                    } while (RepetirMenu);

                }

                else if (RespElevador == "e")
                {
                    RepetInicial = true;
                    ElevadorServico Serv = new ElevadorServico();
                    Serv.Inicializar();

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($@"
    =============================
    |   SELECIONE UMA OPÇÃO:    |
    ----------------------------- 
    | 1- Entrar                 |
    | 2- Sair                   |
    | 3- Subir                  |
    | 4- Descer                 | 
    | 5-Alterar caixas          |    
    | 6- Finalizar              |        
    =============================
                    ");
                        Console.ForegroundColor = ConsoleColor.White;
                        OpçãoMenu = Console.ReadLine();

                        switch (OpçãoMenu)
                        {
                            case "1":
                                RepetirMenu = true;
                                Serv.Entrar();
                                break;

                            case "2":
                                Serv.Sair();
                                RepetirMenu = true;
                                break;

                            case "3":
                                Serv.Subir();
                                RepetirMenu = true;
                                break;

                            case "4":
                                Serv.Descer();
                                RepetirMenu = true;
                                break;

                            case "5":
                                Serv.AlterarCaixas();
                                RepetirMenu = true;
                                break;

                            case "6":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nPrograma finalizado!");
                                Console.ForegroundColor = ConsoleColor.White;
                                RepetirMenu = false;
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nNenhuma opção identificada. Tente nnovamente!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                RepetirMenu = true;
                                break;
                        }
                    } while (RepetirMenu);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nNenhuma opção identificada. Tente nnovamente!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    RepetInicial = false;
                }

            } while (!RepetInicial);
        }
    }
}
