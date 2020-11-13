using System;

namespace Ejercicio2._2._1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Introduce un numero par");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero par");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num1!= 0 || num2!= 0)
            {
                if (num1 % 2 != 0 || num2 % 2 != 0) { Console.WriteLine("Ninguno o uno de los 2 es par"); }
                else
                {
                    if ((num1 % num2 != 0) && (num2 % num1 != 0)) { Console.WriteLine("No es multiplo de nadie"); }
                    if (num1 > num2 && num1 % num2 == 0) { Console.WriteLine(num1 + " es multiplo de " + num2); }
                    else { if (num2 > num1 && num2 % num1 == 0) { Console.WriteLine(num2 + " es multiplo de " + num1); } }
                }
                if(num1==num2 && num1 % num2 == 0) { Console.WriteLine("Es el mismo numero asi que es multiplo " + num1); }
               
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Introduce un numero par");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro numero par");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
           
            
        }
    }
}
