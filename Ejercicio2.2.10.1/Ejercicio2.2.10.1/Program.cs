using System;

namespace Ejercicio2._2._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int e = 0;
            int menor;
            Console.Write("Introduce un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            menor = (num1 < num2 ? num1 : num2);
            for (int i = menor; i >= 1; i--)
            {
                if ((num1 % i == 0) && (num2 % i == 0)) { Console.WriteLine(i); break; }

            }



        }
    }
}
