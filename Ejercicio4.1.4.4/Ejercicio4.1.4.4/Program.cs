using System;

namespace Ejercicio4._1._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5;
            int cantidad = 3;
            int posicionborrar;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(datos[i]);
            }
            Console.Write("Introduce la posicion que deseas borrar: ");
            posicionborrar = Convert.ToInt32(Console.ReadLine());

            posicionborrar--;

            if (capacidad < posicionborrar) 
            {
                Console.WriteLine("Lo siento no hay esa posicion");
            }
            else
            {
                for(int i= posicionborrar; i < cantidad - 1; i++)
                {
                    datos[i] = datos[i+1];
                }
                cantidad--;

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine(datos[i]);
                }
            }
        }
    }
}
