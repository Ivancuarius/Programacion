using System;

namespace Ejercicio2._2._1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100000000;
            int i2 = i;
            int b = 0;
            while (i != 1)
            {
                i = i / 10;
                b = b + 1;
            }
            Console.WriteLine(i2+" tiene/s "+b+" cifras");
        }
    }
}
