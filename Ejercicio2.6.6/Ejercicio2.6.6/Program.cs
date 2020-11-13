using System;

namespace Ejercicio2._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, e;
            for (a = 0; a < 3; a++)
            {
                for (e = 0; e < 4; e++)
                {
                    if    (((a == 1) && (e == 1))
                        || ((a == 1) && (e == 2)))
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
