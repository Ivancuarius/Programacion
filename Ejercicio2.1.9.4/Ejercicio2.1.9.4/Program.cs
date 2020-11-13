using System;

namespace Ejercicio2._1._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Introduce un numero del 1 al 5: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1: Console.WriteLine("Uno"); break;
                case 2: Console.WriteLine("Dos"); break;
                case 3: Console.WriteLine("Tres"); break;
                case 4: Console.WriteLine("Cuatro"); break;
                case 5: Console.WriteLine("Cinco"); break;
                default: Console.WriteLine("He dicho un numero del 1 al 5"); break;

            }
        }
    }
}
