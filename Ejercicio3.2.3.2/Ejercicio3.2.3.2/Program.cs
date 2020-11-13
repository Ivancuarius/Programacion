using System;

namespace Ejercicio3._2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int metros;
            int hora;
            int min;
            int seg;
            float millas = 1.609f;
            float kilometros = 0.001f;
            Console.Write("Introduce los metros: ");
            metros = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce las horas: ");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce los minutos: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce los segundos: ");
            seg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(metros + " en millas " + " son " + (metros * millas));
            Console.WriteLine("Segunos por minutos" + (seg * metros));
            Console.WriteLine("Kilometros por hora" + (hora * (metros*kilometros)));
            Console.WriteLine("Millas por hora" + ((metros * millas) * hora));

        }
    }
}
