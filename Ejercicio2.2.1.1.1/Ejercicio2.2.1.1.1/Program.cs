using System;

namespace Ejercicio2._2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contrasena;//Contraseña
            Console.Write("Buenas, introduce la contraseña ");
            contrasena = Convert.ToInt32(Console.ReadLine());

            while (contrasena != 1111)
            {
                Console.Write("Contraseña incorrecta porfavor intentelo de nuevo ");
                contrasena = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Bienvenido, Ivan ");
        }
    }
}
