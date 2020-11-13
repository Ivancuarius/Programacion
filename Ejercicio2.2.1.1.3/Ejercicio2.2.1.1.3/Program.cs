using System;

namespace Ejercicio2._2._1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Introduce un numero par");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero par");
            num2 = Convert.ToInt32(Console.ReadLine());

            while(num1%num2 != 0)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Introduce un numero par");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro numero par");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(num1 + " es multiplo de " + num2);
        }
    }
}
