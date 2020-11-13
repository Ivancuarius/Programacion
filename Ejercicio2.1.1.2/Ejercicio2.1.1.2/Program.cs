using System;

namespace Ejercicio2._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if(numero1 > numero2)
            { 
                Console.WriteLine(numero1 + " es el mas mayor");
            }
            else
            {
                Console.WriteLine(numero2 + " es el mas mayor");
            }
        }
    }
}
