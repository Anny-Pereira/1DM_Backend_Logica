using System;

namespace exemplo_POO_24_05.classes
{
    public class credito : cartao
    {
        private float Limite = 3000f;

        public void Pagar()
        {
            float valor = this.valor;

            if (valor > Limite)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Seu limite não é suficiente para este valor!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                bool repetir = false;

                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nVocê deseja parcelar o valor de {valor:C2} em quantas vezes? (1 à 12 vezes)");
                    int vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($@"
    Você parcelou em {vezes} vezes, havendo juros de 5% sobre o total, totalizando:

    ===========================================
    |
    |       Total: {valor * 1.05:C2}
    |       Parcelas: {vezes} vezes de {(valor * 1.05) / vezes:C2}
    |
    ===========================================
                    
                    ");
                        repetir = true;
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($@"
    Você parcelou em {vezes} vezes, havendo juros de 8% sobre o total, totalizando:

    ===========================================
    |
    |       Total: {valor * 1.08:C2}
    |       Parcelas: {vezes} vezes de {(valor * 1.08) / vezes:C2}
    |
    ===========================================
                    
                    ");
                        repetir = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEste número não é compatével... Tente novamente!");
                        Console.ForegroundColor = ConsoleColor.White;
                        repetir = false;
                    }
                } while (!repetir);
            }
        }
    }
}