using System;

namespace BlackJack
{


    class Program
    {


        static int suma = 0;


        static void Main(string[] args)


        {

            // Se obtienen dos cartas aleatorias al principio
            Random rond = new Random();
            int A_Cartas = rond.Next(1, 12);
            Random rend = new Random();
            int S_Cartas = rend.Next(1, 12);

            suma = A_Cartas + S_Cartas;


            Console.WriteLine("Tienes " + suma + " cartas.");



            // Mintras se cumpla la condición ejecutará las instrucciones

            while (suma < 21)
            {
               
                //Pregunta al jugador si desea una carta o quedarse asi
                Console.WriteLine("1) Si desea obtener una carta.");
                Console.WriteLine("2) Si desea retirarse.");
                int eleccion = Convert.ToInt32(Console.ReadLine());





                // Si el jugador desea una carta ejecutará estas instrucciones
                if (eleccion == 1)
                {


                    // Obtener carta aleatorias
                    Random rnd = new Random();
                    int O_Cartas = rnd.Next(1, 12);


                    
                    // Hacer que el as valga 11 o 21 segun la situacion
                    if (O_Cartas == 11 && suma >= 11)
                    {
                        O_Cartas = 1;
                    }

                    // Carta random ai
                    Random rand = new Random();
                    int ai = rand.Next(17, 26);


                    
                    // calcula el valor total de las cartas en la mano
                    suma = O_Cartas + suma; 
                    Console.WriteLine("Valor de cartas en mano: " + suma);


                    //Condiciones para ganar

                    //Si el jugador tiene 21 y el dealer menos o más
                    if (suma == 21 && ai != 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    // Si el jugador y el dealer tienen el mismo valor de cartas
                    else if (suma == 21 && ai == 21)
                    {
                        Console.WriteLine("Empate ambos obtuvieron 21 punos");
                    }
                    // Si el jugador tiene más de 21 y el dealer menos o igual a 21
                    else if (suma > 21 && ai <= 21)
                    {
                        Console.WriteLine("Ganó el dealer");
                    }
                    // El jugador tiene más de 21 al igual que el dealer
                    else if (suma > 21 && ai > 21)
                    {
                        Console.WriteLine("Empate! El jugador ha obtenido: " + suma + " y el dealer ha obtenido: " + ai);
                    }



                }
                // Si el jugador no quiere más cartas
                else if (eleccion == 2)
                {
                    // Genera un valor de carta para el dealer
                    Random rand = new Random();
                    int ai = rand.Next(17, 26);
                    Console.WriteLine("La mano del dealer es: " + ai);
                    // Genera una carta aleatoria para la AI

                    // El jugador obtiene un 21 y la casa obtiene un número diferente.
                    if (suma == 21 && ai != 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    //El jugador obtiene un número mayor que la casa, pero menor que 21.
                    else if (suma > ai && suma < 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    //La casa obtiene un número mayor a 21 y el jugador obtiene un número menor o igual que 21.
                    if (ai > 21 && suma <= 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    // sino se cumplen esas condiciones gana el dealer
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