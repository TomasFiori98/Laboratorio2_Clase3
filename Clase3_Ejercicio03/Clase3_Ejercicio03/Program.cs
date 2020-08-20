using System;

namespace Clase3_Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int numero, vidas=3;
            int aleatorio = r.Next(1, 7);

            do
            {
                Console.WriteLine("\nQue numero crees que sea?");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio)
                {
                    Console.WriteLine("\nCorrecto, has acertado!");
                    vidas = 0;
                }
                else
                {
                    vidas -= 1;

                    Console.WriteLine("\nIncorrecto!");
                    Console.WriteLine("--- Vidas restantes: {0} ---", vidas);

                    if (numero > aleatorio && vidas != 0)
                        Console.WriteLine("\nPrueba con un numero mas chico!");
                    if (numero < aleatorio && vidas != 0)
                        Console.WriteLine("\nPrueba con un numero mas grande!");

                    if (vidas == 0)
                        Console.WriteLine("\nPerdiste, te has quedado son vidas :c");

                }

            } while (vidas != 0);

        }
    }
}
