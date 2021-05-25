using System;

namespace POO_2505_sobrecarga.Classes
{
    public class Funcionario
    {
        public string[] Lista = new string[6];

        public void Mostrar()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine(Lista[indice]);
        }

        public void Mostrar(string Buscar)
        {
            for (var i = 0; i < Lista.Length; i++)
            {
                if (Lista[i] == Buscar)
                {
                    Console.WriteLine($"O item '{Lista[i]}' foi encontrado no índice {i}");
                }
            }
        }

    }
}