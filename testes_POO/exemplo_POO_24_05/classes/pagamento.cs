using System;

namespace exemplo_POO_24_05.classes
{
    public class pagamento
    {
        private DateTime Data = DateTime.Now.Date;

        protected float valor = 2500;

        public string Cancelar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "\nPagamento cancelado!";
        }
    }
}