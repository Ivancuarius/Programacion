using System;

namespace Ejercicio2._2._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,fila;

            for(fila=1;fila<=6;fila++)
            {
                for (num = 1; num <= 7; num++)
                {
                    Console.Write(num);
                    if (num == 7) { Console.WriteLine(); }
                }
                
            }
            
        }
    }
}
