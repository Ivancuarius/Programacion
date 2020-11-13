using System;

namespace Ejercicio1._11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul = 3;
            int result = 0;

            for (int i=0; i<=10;i++)
            {
                result = mul * i;
                Console.WriteLine("{0} X {1} = {2}",mul, i, result);
            }

        }
    }
}
