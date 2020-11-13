using System;

namespace Ejercicio4._3._1._1
{
    class Program
    {
        struct tipoCancion
        {
            public string artista;
            public string titulo;
            public int duracion;
            public int tamanyo;
        }

        static void Main(string[] args)
        {
            tipoCancion cancion;

            Console.Write("Introduce el nombre de una cancion: ");
            cancion.titulo = Console.ReadLine();
            Console.Write("Introduce el artista de la cancion: ");
            cancion.artista = Console.ReadLine();
            Console.Write("Introduce cuanto dura la cancion: ");
            cancion.duracion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce su tamaño: ");
            cancion.tamanyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre: {0}",cancion.titulo);
            Console.WriteLine("Artista: {0}",cancion.artista);
            Console.WriteLine("Duracion: {0} segundos",cancion.duracion);
            Console.WriteLine("Tamaño: {0}KB",cancion.tamanyo);
        }
    }
}
