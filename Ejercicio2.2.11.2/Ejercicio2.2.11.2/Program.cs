using System;

namespace Ejercicio2._2._11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 106; i++)
            {
                if (i != 10) { Console.WriteLine(i); }
                i++;
                continue;
            }
        }
    }
}
