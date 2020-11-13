using System;

namespace Ejercicio2._2._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for(x=0;x<5;x++)
            { for (y = 0; y < 4; y++)
                {
                    Console.Write("X");
                    if (y == 3) { Console.WriteLine(); }
                }
            }
            
        }
    }
}
