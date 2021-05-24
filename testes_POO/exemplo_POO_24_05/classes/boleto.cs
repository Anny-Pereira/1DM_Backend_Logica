using System;

namespace exemplo_POO_24_05.classes
{
    public class boleto : pagamento
    {
        private string CodBarras;

        Random r = new Random();

        public void Registrar()
        {
            CodBarras = r.Next(3000000).ToString();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($@"
===================================================================================================            
|    O boleto foi gerado a partir do código {CodBarras}, e possui um desconto de 12%.
|
|    O valor a ser pago é de {this.valor * 0.88:C2}.     
===================================================================================================            
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}