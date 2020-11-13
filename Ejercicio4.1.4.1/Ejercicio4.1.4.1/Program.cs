using System;
using System.Runtime.Versioning;

namespace Ejercicio4._1._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5;
            int cantidad = 3;
            int i = 0;
            int resultado;
            int contados=0;
            Console.Write("Introduce un numero: ");
            resultado = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < cantidad; i++)
            {
                if (resultado == datos[i])
                {
                    contados += 1;
                }
            }
            if (contados >= 1)
            {
                Console.WriteLine("Si que hay en la tabla de datos, exactamente hay " + contados + " " + resultado);
            }
            else
            {
                Console.WriteLine("Lo siento no hay ningun " + resultado);
            }
        }
    }
}
