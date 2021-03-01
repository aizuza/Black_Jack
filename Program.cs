using System;

namespace BlackJack
{


    class Program
    {


        static int suma = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Tienes " + suma + " cartas.");

            while (suma < 21)
            {
                /// <summary>
                /// Pregunta si quieres cartas o terminar el juego
                /// </summary>
                /// <returns>1 o 2</returns>

                Console.WriteLine("1) Si desea obtener una carta.");
                Console.WriteLine("2) Si desea retirarse.");
                int eleccion = Convert.ToInt32(Console.ReadLine());


                /// <summary>
                /// Obtener carta aleatorias
                /// </summary>
                /// <returns>1 o 2</returns>


                if (eleccion == 1)
                {
                    // n = n+1;
                    /// <summary>
                    /// Obtener carta aleatorias
                    /// </summary>
                    /// <returns>1 o 2</returns>

                    Random rnd = new Random();
                    int O_Cartas = rnd.Next(1, 12);




                    /// <summary>
                    /// calcula el valor total de las cartas en la mano
                    /// </summary>

                    suma = O_Cartas + suma; //sumamos el numero de cartas del jugador con el puntaje de las cartas aleatorias


                    Console.WriteLine("Valor de cartas en mano: " + suma);






                }
                else if (eleccion == 2)
                {

                    // Genera una carta aleatoria para la AI

                    Random rnd = new Random();
                    int ai = rnd.Next(17, 26);
                    Console.WriteLine("La mano del dealer es: " + ai);
                    Console.WriteLine("La mano del jugador es: " + suma);



                    break;
                }




            }

        }


    }
}