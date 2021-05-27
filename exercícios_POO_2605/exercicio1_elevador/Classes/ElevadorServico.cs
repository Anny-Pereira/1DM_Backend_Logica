using System;

namespace exercicio1_elevador.Classes
{
    public class ElevadorServico : Elevador
    {
        private int MaxCaixas = 20;

        public void AlterarCaixas()
        {
            int Resp;
            int Quant;

            Console.WriteLine("Há quantas caixas no elevador?");
            Resp = int.Parse(Console.ReadLine().ToLower());

            if (Resp == MaxCaixas)
            {
                Console.WriteLine("Não será possível adicionar mais caixas.");
            }

            else if (Resp < MaxCaixas)
            {
                Console.WriteLine("Quantas caixas serão adicionadas?");
                Quant = int.Parse(Console.ReadLine());

                int TotalCaixas = Resp + Quant;

                if (TotalCaixas <= MaxCaixas)
                {
                    Console.WriteLine("Caixas adicionadas!");
                }
                else if (TotalCaixas > 20)
                {
                    Console.WriteLine("Não é possível levar essa quantidade de caixas.");
                }
            }
        }
    }
}