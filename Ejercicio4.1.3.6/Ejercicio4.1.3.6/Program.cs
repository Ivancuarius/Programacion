using System;

namespace Ejercicio4._1._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = 10;
            string[] nombres = new string[vez];
            for(int i = 0; i < vez; i++)
            {
                Console.Write("Introduce un nombre: ");
                nombres[i] = Convert.ToString(Console.ReadLine());
            }
            string resuelve;
            int solucion = 0;
            do
            {
                Console.Write("Introduce un nombre que hayas puesto: ");
                resuelve = Console.ReadLine();
                for (int a = 0; a < vez; a++)
                {

                    if (resuelve == nombres[a])
                    {
                        solucion = 1;
                    }
                    
                }
                if (resuelve == "Fin" || resuelve=="fin")
                {
                    solucion = 1;
                }

            } while (solucion != 1);

            Console.WriteLine("Bien");
            


        }
    }
}
