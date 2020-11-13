using System;
using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace Ejercicio2._1._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.Write("Introduce lo que tu quieras ");
            a = Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case '.':
                case ';':
                case ':':
                case ',': Console.WriteLine("Signo de puntuacion"); break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0': Console.WriteLine("Signo Numerico"); break;
                default: Console.WriteLine("Introduce otra cosa"); break;

            }
        }
    }
}

