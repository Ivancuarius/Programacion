using System;

namespace Ejercicio3._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            int c;
            b = ++a;
            c = a++;
            b = b * 5;
            a = a * 2;
            Console.WriteLine(a+"\t"+b+"\t"+c);
        }
    }
}
