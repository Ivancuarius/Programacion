using System;

namespace Ejercicio4._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros=new double [4];
            double result;
            Console.Write("Introduce el primer numero: ");
            numeros[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el segundo numero: ");
            numeros[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el tercer numero: ");
            numeros[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el cuarto numero: ");
            numeros[3] = Convert.ToDouble(Console.ReadLine());

            result = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4;

            Console.WriteLine("La media de " + numeros[0] + " " + numeros[1] + " " + numeros[2] + " " + numeros[3] + " es de " + result);
        }
    }
}
