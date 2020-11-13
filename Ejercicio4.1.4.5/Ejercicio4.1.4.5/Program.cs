using System;

namespace Ejercicio4._1._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datos = { "","","","","","","","","","" };
            int capacidad = 10;
            int cantidad = 0;

            int funcion;

            string insertar;
            int posicion;
            do
            {
                Console.WriteLine("Introduce un numero para hacer uno de las siguientes funciones: ");
                Console.WriteLine("1º Añadir un dato al final de los ya existentes.");
                Console.WriteLine("2º Insertar un dato en una cierta posición");
                Console.WriteLine("3º Borrar el dato que hay en una cierta posición");
                Console.WriteLine("4º Mostrar los datos que contiene el array.");
                Console.WriteLine("5º Salir del programa.");
                Console.WriteLine("");
                funcion = Convert.ToInt32(Console.ReadLine());

                switch (funcion)
                {
                    case 1 :
                        Console.Write("Introduce lo que deseas poner: ");
                            insertar = Console.ReadLine();
                            if (cantidad < capacidad)
                            {
                                datos[cantidad] = insertar;
                            }
                            cantidad++;
                            Console.WriteLine("Ya esta insertado");
                            Console.WriteLine("");
                            ; break;

                    case 2:
                        Console.Write("Introduce lo que deseas poner: ");
                        insertar = Console.ReadLine();
                        Console.Write("Introduce en que posicion deseas poner: ");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        posicion--;
                        if (capacidad < posicion)
                        {
                            Console.WriteLine("Lo siento pero esa posicion no hay");
                        }
                        else
                        {
                            for (int a = cantidad; a > posicion ; a--)
                            {
                                datos[a] = datos[a - 1];
                            }
                            datos[posicion] = insertar;
                            cantidad++;
                            Console.WriteLine("Ya esta insertado");
                            Console.WriteLine("");
                        }
                        ;break;
                    case 3:
                        Console.Write("Introduce la posicion que deseas borrar: ");
                        posicion = Convert.ToInt32(Console.ReadLine());

                        posicion--;

                        if (capacidad < posicion)
                        {
                            Console.WriteLine("Lo siento no hay esa posicion");
                        }
                        else
                        {
                            for (int i = posicion; i < cantidad - 1; i++)
                            {
                                datos[i] = datos[i + 1];
                            }
                            cantidad--;
                            Console.WriteLine("Ya esta eliminado");
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                        ;break;
                    case 4:
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(datos[i]);
                        }
                        Console.WriteLine("");
                        ; break;
                }

            } while (funcion != 5);
            Console.WriteLine("Bien adios");
        }
    }
}



