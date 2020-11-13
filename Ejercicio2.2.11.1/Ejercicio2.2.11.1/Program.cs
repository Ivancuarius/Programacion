using System;

namespace Ejercicio2._2._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=20;i>=10;i--)
            {
                if (i != 13) { Console.WriteLine(i); }
                continue;
            }
        }
    }
}
