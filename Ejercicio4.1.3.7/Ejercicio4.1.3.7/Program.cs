using System;

namespace Ejercicio4._1._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = 100;
            string[] nombres = new string[vez];
            for (int i = 0; i < vez; i++)
            {
                Console.Write("Introduce un nombre: ");
                nombres[i] = Convert.ToString(Console.ReadLine());

                if(nombres[i]=="")
                {
                    vez = i;
                    break;
                }

            }
            for (int a = 0; a < vez; a++)
            {
                Console.WriteLine(nombres[a]);
            }
        }
    }
}
