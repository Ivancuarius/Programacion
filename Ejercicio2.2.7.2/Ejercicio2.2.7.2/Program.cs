using System;

namespace Ejercicio2._2._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            int a;
            for (a = 0; a < 5; a++)
            {
                for (letra = 'L'; letra <= 'P'; letra++)
                {
                    Console.Write(letra);
                    if (letra == 'P') { Console.WriteLine(); }
                }  
            }
        }
    }
}
