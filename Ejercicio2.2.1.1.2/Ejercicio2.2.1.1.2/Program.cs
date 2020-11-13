using System;

namespace Ejercicio2._2._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int calc;
            Console.Write("Introduce un numero (0 para salir) ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num != 0)
            {
                calc = num * num;
                Console.WriteLine("Es " + calc + ". Introduce otro numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Adios, que tengas un buen dia");
        }
    }
}
