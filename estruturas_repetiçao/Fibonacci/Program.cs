using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumeroAnterior = -1;
            int NumeroAtual = 1;
            int Resultado; 

            for (var i = 0; i < 15; i++)
            { 
                Resultado = NumeroAnterior + NumeroAtual;
                NumeroAnterior = NumeroAtual;
                NumeroAtual = Resultado;

                Console.Write( Resultado + ", ");
            }

        
        }
    }
}
