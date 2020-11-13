using System;

namespace Ejercicio2._1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int res = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Introduce otro numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            res = numero1 % numero2;
            if (res == 0)
            {
                Console.WriteLine(numero1+" es multiplo de "+numero2);
            }
            else
            {
                Console.WriteLine(numero1 + " no es multiplo de " + numero2);
            }
        }
    }
}
