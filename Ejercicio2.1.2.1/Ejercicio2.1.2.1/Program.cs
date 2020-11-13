using System;

namespace Ejercicio2._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if((numero1 % 10)==0)
            {
                Console.WriteLine("Vale, es un numero primo de 10.");
                Console.Write("Bien pues ahora pon otro numero que sea primo ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                if((numero2 % 10) == 0)
                {
                    Console.WriteLine("Bien tambien es un numero primo");
                }
                else
                {
                    Console.WriteLine("Ese si que no es un numero primo");
                }
            }
            else
            {
                Console.Write("Lo siento pero no es un numero primo de 10");
            }
        }
    }
}
