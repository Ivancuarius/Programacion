using System;

namespace Ejercicio2._2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 5 == 0) { Console.WriteLine("Es numero primo de 5 "); }
                if (i % 6 == 0) { Console.WriteLine("Es numero primo de 6 "); }
                if (i % 7 == 0) { Console.WriteLine("Es numero primo de 7 "); }
                Console.WriteLine("-------------------------------------------");
            }
            
        }
    }
}
