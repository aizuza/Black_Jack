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
                    // intento
                    Random rand = new Random();
                    int ai = rand.Next(17, 26);


                    /// <summary>
                    /// calcula el valor total de las cartas en la mano
                    /// </summary>

                    suma = O_Cartas + suma; //sumamos el numero de cartas del jugador con el puntaje de las cartas aleatorias


                    Console.WriteLine("Valor de cartas en mano: " + suma);


                    //Condiciones para ganar



                    if (suma == 21 && ai != 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    else if (suma == 21 && ai == 21)
                    {
                        Console.WriteLine("Empate ambos obtuvieron 21 punos");
                    }
                    else if (suma > 21)
                    {
                        Console.WriteLine("Ganó el dealer");
                    }
                    else if (suma > 21 && ai <= 21)
                    {
                        Console.WriteLine("Ganó el dealer");
                    }
                    else if (suma > 21 && ai > 21)
                    {
                        Console.WriteLine("Empate! El jugador ha obtenido: " + suma + " y el dealer ha obtenido: " + ai);
                    }



                }
                else if (eleccion == 2)
                {

                    Random rand = new Random();
                    int ai = rand.Next(17, 26);
                    Console.WriteLine("La mano del dealer es: " + ai);
                    // Genera una carta aleatoria para la AI

                    // El jugador obtiene un 21 y la casa obtiene un número menor.
                    if (suma == 21 && ai != 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    //El jugador y la casa obtienen un número menor o igual a 21, pero el jugador obtiene un número más alto.
                    else if (suma > ai && suma < 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    //La casa obtiene un número mayor a 21 y el jugador obtiene un número menor o igual que 21.
                    if (ai > 21 && suma <= 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    else
                    {
                        Console.WriteLine("Ganó el dealer");
                    }
                    break;
                }
            }
        }
    }
}