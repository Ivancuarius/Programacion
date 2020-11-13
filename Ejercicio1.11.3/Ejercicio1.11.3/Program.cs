using System;

namespace Ejercicio1._11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul = 0;
            int result = 0;
            Console.Write("Introduce un numero ");
            mul = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                result = mul * i;
                Console.WriteLine(mul+" X "+ i + " = " + result);
            }

        }
    }
}