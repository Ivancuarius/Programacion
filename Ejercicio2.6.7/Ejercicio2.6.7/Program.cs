using System;

namespace Ejercicio2._6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a;
            int e = 3;
            for (i = 0; i < 4; i++)
            {
                for (a = 0; a < 4; a++)
                {
                    if (a < e)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
                e--;
            }
            
        }
    }
}
