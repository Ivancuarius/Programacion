using System;

namespace Ejercicio2._1._5._6
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

            if ((numero1 % 2 == 0) || (numero2 % 2 == 0))
            {
                Console.Write(numero1 + " o " + numero2 + " es pares");
            }
            else
            {
                Console.Write("Ninguno de los 2 es par");
            }
        }
    }
}
