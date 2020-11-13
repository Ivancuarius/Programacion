using System;

namespace Ejercicio2._1._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if ((numero1 % 2) == 0 || (numero1 % 3) == 0)
            {
                Console.WriteLine("Es numero primo de 2 o de 3");
            }
            else
            {
                Console.WriteLine("No es numero primo de 2 o de 3");
            }
        }
    }
}
