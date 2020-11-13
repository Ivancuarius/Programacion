using System;

namespace Ejercicio2._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int ano;

            try
            {
                Console.Write("Introduce su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("No es un número válido");
            }
            try { 
            Console.Write("Introduce el año que nacistes: ");
                ano = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("No es un número válido");
            }




        }
    }
}
