using System;

namespace POO_2505_polimorfismo.Classes
{
    public abstract class Players
    {
        private float Velocidade;

        private float ForcaPulo;

        public virtual string Correr()
        {
            return "O player correu!";
        }

        public virtual string Pular()
        {
            return "O player pulou!";
        }

    }
}