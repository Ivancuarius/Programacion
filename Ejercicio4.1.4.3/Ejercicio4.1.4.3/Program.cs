using System;

namespace Ejercicio4._1._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5;
            int cantidad = 3;

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(datos[i]);
            }
            Console.Write("Introduce un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ahora introduce donde quieres ponerlo: ");
            int posicion = Convert.ToInt32(Console.ReadLine());
            posicion--;


            if (capacidad < posicion)
            {
                Console.WriteLine("Lo siento pero esa posicion no hay");
            }
            else
            {
                for (int i = cantidad; i > posicion; i--)
                {
                    datos[i] = datos[i - 1];
                }
                datos[posicion] = numero;
                cantidad++;


                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine(datos[i]);
                }
            }
        }
    }
}
