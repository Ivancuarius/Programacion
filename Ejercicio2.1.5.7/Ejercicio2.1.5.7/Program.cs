using System;

namespace Ejercicio2._1._5._7
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

            if ((numero1 % 2 == 0) && (numero2 % 2 != 0))
            {
                Console.Write(numero1+" es el par");
            }
            else
            {
                if ((numero2 % 2 == 0) && (numero1 % 2 != 0))
                {
                    Console.Write(numero2 + " es el par");
                }
                else
                {
                    if ((numero1 % 2 == 0) && (numero2 % 2 == 0))
                    {
                        Console.Write("Los dos son par a si que no te lo enseño :3");
                    }
                }
            }
        }
    }
}
