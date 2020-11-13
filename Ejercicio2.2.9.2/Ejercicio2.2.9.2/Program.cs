using System;

namespace Ejercicio2._2._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,i;
            Console.Write("Introduce un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (i = 1; (i <= num1)||(i<=num2); i++)
            {
                if ((num1 % i == 0)&&(num2%i==0)) { Console.WriteLine(i); }
            }
        }
    }
}
