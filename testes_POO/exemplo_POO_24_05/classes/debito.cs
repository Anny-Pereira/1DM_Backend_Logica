using System;

namespace exemplo_POO_24_05.classes
{
    public class debito : cartao
    {
        private float saldo = 600f;

        public void Pagar()
        {
            float valor = this.valor;

            if (saldo > valor)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nO pagamento sobre o valor de {valor:C2} foi efetuado com sucesso!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (saldo < valor)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nO seu saldo não é suficiente para efetuar o pagamento...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}