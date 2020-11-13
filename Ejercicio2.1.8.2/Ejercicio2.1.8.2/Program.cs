using System;

namespace Ejercicio2._1._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int result;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            result = numero1 < numero2 ? numero1:numero2;
            Console.Write(result);

        }
    }
}
