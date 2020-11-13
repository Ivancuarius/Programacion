using System;

namespace Ejercicio2._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int result = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.Write("Error: No se puede dividirentre cero");
            }
            else {
                result = numero1 / numero2;
                Console.Write(numero1 + " / " + numero2 + " = " + result);
            }
        }
    }
}
