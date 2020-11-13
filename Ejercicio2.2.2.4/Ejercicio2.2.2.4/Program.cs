using System;

namespace Ejercicio2._2._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int us, con;
            do
            {
                Console.Write("Introduce el usuario ");
                us = Convert.ToInt32(Console.ReadLine());
            } while (us!=1234);
            do
            {
                Console.Write("Introduce la contraseña ");
                con = Convert.ToInt32(Console.ReadLine());
            } while (con !=1111);
            Console.WriteLine("Bienvenido");
        }
    }
}
