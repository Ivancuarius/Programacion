using System;

namespace Ejercicio2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;
            Console.Write("Introduce un numero entero para ver si es par o no ");
            num = Convert.ToInt16(Console.ReadLine());
            result = num % 2;
            if (result == 0)
                {
                Console.Write("Es par");
                    }
            else
            {
                Console.Write("No es par");
            }
            
        }
    }
}
