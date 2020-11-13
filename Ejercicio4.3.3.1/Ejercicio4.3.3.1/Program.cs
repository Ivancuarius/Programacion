using System;

namespace Ejercicio4._3._3._1
{
    class Program
    {
        struct tiempoDuracion
        {
            public string segundos;
            public string minutos;
        }
        struct tipoCancion
        {
            public string artista;
            public string titulo;
            public tiempoDuracion tiempo;
            public string tamanyo;
        }
        static void Main(string[] args)
        {
            int canciones = 1;
            string buscar;
            int selector = 0;
            tipoCancion[] cancion = new tipoCancion[100];

            cancion[0].artista = "Lyn Inaizumi";
            cancion[0].titulo = "Take over";
            cancion[0].tiempo.segundos= "04";
            cancion[0].tiempo.minutos = "03";
            cancion[0].tamanyo = "1888";

            do
            {
                Console.WriteLine("Introduce un numero segun lo que quieres hacer");
                Console.WriteLine("1º Añadir una cancion");
                Console.WriteLine("2º Ver las listas de las canciones");
                Console.WriteLine("3º Buscar una cancion");
                Console.WriteLine("4º Salir");
                Console.WriteLine();
                selector = Convert.ToInt32(Console.ReadLine());

                switch (selector)
                {
                    case 1:
                        Console.WriteLine("--------------------------------------");
                        if (canciones > 100)
                        {
                            Console.WriteLine("Lo siento solo podemos guardar 100 canciones");

                        }
                        else
                        {
                            Console.Write("Introduce el nombre de una cancion: ");
                            cancion[canciones].titulo = Console.ReadLine();
                            Console.Write("Introduce el artista de la cancion: ");
                            cancion[canciones].artista = Console.ReadLine();
                            Console.Write("Introduce cuanto dura la cancion (Minutos y luegos segundos): ");
                            cancion[canciones].tiempo.minutos = Console.ReadLine();
                            cancion[canciones].tiempo.segundos = Console.ReadLine();
                            Console.Write("Introduce su tamaño: ");
                            cancion[canciones].tamanyo = Console.ReadLine();
                            canciones += 1;
                        }
                        Console.WriteLine("--------------------------------------");
                        ; break;
                    case 2:
                        Console.WriteLine("--------------------------------------");
                        for (int i = 0; i < canciones; i++)
                        {
                            Console.WriteLine("{2}º {0}/{1} {3}:{4}", cancion[i].titulo, cancion[i].artista, i + 1,cancion[i].tiempo.minutos, cancion[i].tiempo.segundos);
                        }
                        Console.WriteLine("--------------------------------------");
                        ; break;
                    case 3:
                        Console.WriteLine("--------------------------------------");
                        Console.Write("Bien introduce la cancion que buscas (puedes buscarlo escribiendo el titulo de la cancion o el artistas): ");
                        buscar = Console.ReadLine();

                        for (int i = 0; i < canciones; i++)
                        {
                            if (buscar == cancion[i].titulo || buscar == cancion[i].artista)
                            {
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("{2}º {0}/{1} {3}:{4}", cancion[i].titulo, cancion[i].artista, i + 1,cancion[i].tiempo.minutos, cancion[i].tiempo.segundos);
                            }
                            else
                            {
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Lo siento no se ha encontrado esa cancion");
                            }
                        }
                        Console.WriteLine("--------------------------------------");
                        ; break;
                    case 4:
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Adios y vuelve cuando quieras");
                        ; break;
                    default:
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Lo siento pero ese numero no esta, vuelve a intentarlo");
                        Console.WriteLine("--------------------------------------");
                        break;

                }
            } while (selector != 4);
        }

    }
}
