using System;

namespace Ejercicio2._2._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int largo = 0;
            int ancho = 0;
            int x, y;
            Console.Write("Introduce el largo: ");
            largo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            for (y = 0; y < largo; y++)
            {
                for (x = 0; x <= ancho-1; x++)
                {
                    Console.Write("X");
                    if (x >= ancho-1) { Console.WriteLine(); }
                }
            }
        }
    }
}
