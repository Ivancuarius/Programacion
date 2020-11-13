using System;
using System.Text.RegularExpressions;

namespace Ejercicio3._2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double largo,ancho,perimetro,area, diagonal;
            Console.Write("Introduce la altura del rectangulo: ");
            largo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la ancho del rectangulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            perimetro = largo + largo + ancho + ancho;
            area = largo * ancho;
            diagonal = Math.Sqrt((largo * largo) + (ancho * ancho));

            Console.WriteLine("Su pelimetro es de " + perimetro.ToString("0.0"));
            Console.WriteLine("Su area es de " + area.ToString("0.0"));
            Console.WriteLine("Su diagonal es de " + diagonal.ToString("0.0"));
        }
    }
}
