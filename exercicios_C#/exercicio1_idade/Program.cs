using System;

namespace exercicio1_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá. Quantos anos você tem?");
            int SuaIdade = int.Parse(Console.ReadLine());

            int IdadeMeses = SuaIdade * 12;
            Console.WriteLine("Sua idade em meses é de: " + IdadeMeses);

             int IdadeDias = SuaIdade * 365;
            Console.WriteLine("Sua idade em dias é de: " + IdadeDias + " dias!");

            // 1 ano tem 8760 horas
            int IdadeHoras = SuaIdade * 8760;
            Console.WriteLine("Sua idade em horas é de: " + IdadeHoras + " horas!");
            
            // 1 ano tem 525.600 minutos
            int IdadeMinutos = SuaIdade * 525600;
            Console.WriteLine("Sua idade em minutos é de: " + IdadeMinutos + " minutos!");


        }
    }
}
