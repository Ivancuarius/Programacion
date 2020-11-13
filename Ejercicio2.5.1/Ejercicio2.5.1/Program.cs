using System;

namespace Ejercicio2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Escribe alguna palabra o una frase: ");
            string nombre = Console.ReadLine();
            foreach (char letra in nombre)
            {
                if (letra == 'a'|| letra == 'A')
                {
                    a = a + 1;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("No hay ningna A en la palabra u frase");
            }
            else
            Console.WriteLine("Hay " + a + " A");
        }
    }
}
