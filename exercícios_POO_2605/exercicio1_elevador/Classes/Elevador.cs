using System;

namespace exercicio1_elevador.Classes
{
    public abstract class Elevador
    {
        // public int Terreo;

        private int Andares { get; set; }

        public int CapElev { get; set; }

        public int NumPessoasElv = 0;

        public int RespAndar;
        public int RespAndarDescer;

        public int TotalPessoas;

        public int AndarAtual = 0;


        public void Inicializar()
        {
            int AndaresPrédio;
            int CapacidadeElevador;

            Console.WriteLine("\nQuantos andares há no prédio?");
            AndaresPrédio = int.Parse(Console.ReadLine());
            Andares = AndaresPrédio;

            Console.WriteLine("\nQual a capacidade de pessoas do elevador do prédio?");
            CapacidadeElevador = int.Parse(Console.ReadLine());
            CapElev = CapacidadeElevador;
        }


        public void Entrar()
        {
            int QuantPessoas;

            Console.WriteLine("Quantas pessoas já estão no elevador?");
            NumPessoasElv = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas pessoas vão entrar no elevador?");
            QuantPessoas = int.Parse(Console.ReadLine());

            TotalPessoas = NumPessoasElv + QuantPessoas;

            if (TotalPessoas < CapElev)
            {
                Console.WriteLine("Ainda há espaço para entrar.");
            }
            else if (TotalPessoas >= CapElev)
            {
                Console.WriteLine("Não há mais espaço para entrar!");
            }
        }

        public void Sair()
        {
            if (TotalPessoas != 0)
            {
                int PessoaSair;

                Console.WriteLine("Quantas pessoas sairão do elevador?");
                PessoaSair = int.Parse(Console.ReadLine());
                Console.WriteLine($"{PessoaSair} pessoas saíram do elevador.");
            }
            else
            {
                Console.WriteLine("Não há ninguém para sair.");
            }
        }
        public void Subir()
        {
            if (TotalPessoas != 0)
            {
                Console.WriteLine("Para qual andar você deseja ir?");
                RespAndar = int.Parse(Console.ReadLine());


                if (RespAndar <= Andares)
                {
                    int Temp = RespAndar - AndarAtual;
                    for (var i = 0; i < Temp; i++)
                    {
                        // Console.WriteLine($"{AndarAtual}, {i}");
                        AndarAtual = AndarAtual + 1;
                        Console.WriteLine($"O elevador subiu, agora está no {AndarAtual}º andar .");
                    }
                }
                else if (RespAndar > Andares)
                {
                    Console.WriteLine("Não é póssível que o elevador suba mais!");
                }
            }
            else
            {
                Console.WriteLine("Não há ninguém no elevador.");
            }
        }

        public void Descer()
        {
            Console.WriteLine("Para qual andar você deseja ir?");
            RespAndarDescer = int.Parse(Console.ReadLine());

            if (RespAndarDescer <= 0)
            {
                Console.WriteLine("Não é póssível que o elevador desça mais!");
            }

         
             else if (RespAndarDescer > 0 && RespAndarDescer <= Andares)
            {
                int Temp = RespAndar - RespAndarDescer;
                for (var i = 0; i < Temp; i++)
                {
                    AndarAtual = AndarAtual - 1;
                    Console.WriteLine($"O elevador desceu, agora está no {AndarAtual}º andar .");
                }
            }
        }

    }
}