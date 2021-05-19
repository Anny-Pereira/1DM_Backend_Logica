using System;

namespace POO_celular
{
    class Program
    {
        static void Main(string[] args)
        {

            bool NãoQuero = false;

            var hora = DateTime.Now.Hour;
            var min = DateTime.Now.Minute;


            Celular FuncCelular = new Celular();

            if (FuncCelular.Ligar())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nO celular está ligado!\n");
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($@"
    Escolha alguma função:
    ===============================
    |  BR                   {hora}:{min} |
    |-----------------------------|
    ||                           ||
    ||                           ||
    ||  1- Enviar mensagem       || 
    ||  2- Fazer ligação         || 
    ||  3- Mostrar propriedades  ||
    ||  4- Desligar              ||
    ||                           ||
    ||                           ||
    |-----------------------------|
    |              O              |
    ===============================
                    ");
                    string EscolhaFunção = Console.ReadLine();

                    switch (EscolhaFunção)
                    {
                        case "1":
                            Console.WriteLine(FuncCelular.EnviarMsg());
                            break;

                        case "2":
                            Console.WriteLine(FuncCelular.Ligação());
                            break;

                        case "3":
                            PropriedadesCelular();
                            break;

                        case "4":
                            FuncCelular.Desligar();
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nO celular está desligado!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Selecione caso queira:");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(@"
    =================
    | 1- Ligar      |                
    | 2- Não quero  |                
    =================
                                ");
                                Console.ForegroundColor = ConsoleColor.White;
                                string RespLigar = Console.ReadLine();

                                if (RespLigar == "1")
                                {
                                    FuncCelular.Ligar();
                                    FuncCelular.LigDes = true;

                                }

                                else if (RespLigar == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nO celular está desligado!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    NãoQuero = true;
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nNenhuma opção identificada!\n");
                                    FuncCelular.LigDes = false;
                                }
                            }
                            while (!NãoQuero && !FuncCelular.LigDes);
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNenhuma opção identificada!\n");
                            break;
                    }
                }
                while (FuncCelular.LigDes);
            }
        }

        static void PropriedadesCelular()
        {
            Celular Propriedades = new Celular();

            Console.WriteLine("Propriedades deste celular:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
    =========================================
    | {Propriedades.cor}                    
    | {Propriedades.modelo}                 
    | {Propriedades.versão}                 
    | {Propriedades.tamanho}                
    | {Propriedades.memória}                
    =========================================
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
