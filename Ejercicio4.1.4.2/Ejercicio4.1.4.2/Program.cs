using System;

namespace Ejercicio4._1._4._2
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

            if (cantidad < capacidad)
            {
                datos[cantidad] = numero;
                cantidad++;
            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(datos[i]);
            }
        }
    }
}
