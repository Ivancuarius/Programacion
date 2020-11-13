using System;
using System.Reflection.Metadata;

namespace Ejercicio2._2._1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 5; //new Random().Next(1, 10);
            int resuelto=0;
            int i = 1;
            Console.WriteLine("Introduce un numero del 1 al 10 ");
            resuelto = Convert.ToInt32(Console.ReadLine());
            while (i != 3 && resuelto!=randomNumber)
            {
                Console.Write("Error introduce otro ");
                resuelto = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
            }
            if (resuelto == randomNumber)
            {
                Console.Write("Felicidades");
            }
            else { Console.Write("Lo siento se ha equivocado 3 veces vuelve a intentarlo"); }
        }
    }
}
