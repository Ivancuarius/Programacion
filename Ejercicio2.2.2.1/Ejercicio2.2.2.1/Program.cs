using System;

namespace Ejercicio2._2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 0;
            do
            {
                Console.WriteLine("Introduce un numero ");
                num = Convert.ToInt32(Console.ReadLine());
                i = num + i;
            }
            while (num > 0);
            Console.WriteLine(i);
        }
    }
}
