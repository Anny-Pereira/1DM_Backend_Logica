using System;


namespace POO_celular
{
    public class Celular
    {
        // propiedades deste celular
        public string cor = "Cor:                 Rose";

        public string modelo = "Modelo:              iPhone 7";

        public string versão = "Versão:              iOS 13.6.1";

        public string tamanho = "Tamanho:             4,7 polegadas";

        public string memória = "Memória interna:     32 GB";


        public bool LigDes;

         public bool Ligar()
         {
            return LigDes = true;
         }

         public bool Desligar()
         {
            return LigDes = false;
         }

         public string EnviarMsg ()
         {
            Console.WriteLine("Escreva uma mensagem:");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            return "Mensagem enviada!";
         }

         public string Ligação ()
         {
            Console.WriteLine("Disque o número:");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return "Não é possível realizar essa ligação. Você está sem saldo!";

         }



    }
}