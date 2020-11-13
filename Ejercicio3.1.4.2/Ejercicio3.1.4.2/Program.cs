using System;

namespace Ejercicio3._1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            a = 5;
            b = a + 2;
            b -= 3;
            c = -3;
            c *= 2;
            ++c;
            a *= b;
            Console.WriteLine(a+"\t"+b+"\t"+c);
            //a 5*4=20  b7-3=4 c-3*2=-6=-5
        }
    }
}
