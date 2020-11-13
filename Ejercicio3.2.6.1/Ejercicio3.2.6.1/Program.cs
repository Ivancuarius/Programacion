using System;

namespace Ejercicio3._2._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Introduce un numero; ");
                numero = Convert.ToInt32(Console.ReadLine());
                Convert.ToString(numero, 10);
            } while (numero == 0);

        }
    }
}
