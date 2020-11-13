using System;

namespace Ejercicio3._2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.Write("Introduce un numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            n1 = n1 * n1;

            float result = Convert.ToInt32(n1);
            Console.Write("Eso da "+result);
        }
    }
}
