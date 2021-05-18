using System;

namespace teste_POO
{
    public class personagem
    {
        public string nome;

        public int idade;

        public string habilidade;
        
        public int pontoVida;

        public int Atacar()
        {
            int Ataque = 10;
            return Ataque;
        }

        public int Defender()
        {
            int Defesa = 5;
            return Defesa;
        }

        
    }
}