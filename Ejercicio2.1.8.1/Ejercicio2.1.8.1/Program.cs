using System;

namespace Ejercicio2._1._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int result;
            Console.WriteLine("Introduce un numero ");
            numero = Convert.ToInt32(Console.ReadLine());
            result = numero < 0 ? (0-numero): numero;
            Console.WriteLine(result);

        }
    }
}
