using System;

namespace Ejercicio2._2._12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 20; i >= 10; i--)
            {
                if (i == 14)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int a = 20;

            while (a >= 10)
            {
                if (a == 14)
                {
                    a--;
                    continue;
                }
                Console.Write(a + " ");
                a--;
            }
        }
    }
}
