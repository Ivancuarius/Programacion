using System;

namespace Ejercicio2._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int vece = 0;
            int calc = 0;
            Console.WriteLine("Introduce un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora cuantas veces quieres quieres que lo sume");
            vece = Convert.ToInt32(Console.ReadLine());
            calc = num;
            while (vece != 1)
            {
                num = calc + num;
                vece--;
            } 
                Console.WriteLine("Da " + num);

        }
    }
}
