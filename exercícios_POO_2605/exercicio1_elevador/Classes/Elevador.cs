using System;

namespace exercicio1_elevador.Classes
{
    public abstract class Elevador
    {
        public int Terreo;

        public int Andares = 10;

        public int CapElev = 15;

        public int NumPessoasElv; 

        public void Inicializa( int CapElev, int Andares)
        {}

        public void Entrar()
        {
            if (NumPessoasElv < CapElev)
            {
                Console.WriteLine("Ainda há espaço para entrar.");
            }
            else if (NumPessoasElv >= CapElev)
            {
                Console.WriteLine("Não há mais espaço para entrar!");
            }
        }

        public void Sair()
        {
            if (NumPessoasElv != 0)
            {
                Console.WriteLine("As pessoas saíram do elevador.");
            }
        }


    }
}