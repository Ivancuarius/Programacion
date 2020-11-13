using System;

namespace Ejercicio2._2._3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=100;i<=200;i++)
                if ((i % 3 == 0) && (i % 7 == 0)) { Console.WriteLine(i); }
            
        }
    }
}
