using System;

namespace Ejercicio2._1._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if ((numero1 % 2 != 0) && (numero1 % 3 != 0))
            {
                Console.WriteLine("No es numero multiplo ni de 2 ni de 3");
            }
            else
            {
                Console.WriteLine("Si que es un numero multiplo");
            }
        }
    }
}
