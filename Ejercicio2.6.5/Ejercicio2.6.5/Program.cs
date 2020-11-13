using System;

namespace Ejercicio2._6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int a;
            int e = 4;
            for( i = 0; i < 4; i++)
            {
                for( a = 0; a < e; a++)
                {
                    if (a == e)
                    {
                        continue;
                    }
                    Console.Write("*");
                   
                    
                }
                Console.WriteLine();
                --e;

            }
        }
    }
}
