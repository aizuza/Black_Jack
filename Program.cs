using System;

namespace BlackJack
{


    class Program
    {

       
        static int suma = 0;
        
        static void Main(string[] args)
        {
           Console.WriteLine("Tienes " + suma + " cartas.");
            
            Console.WriteLine("1) Si desea obtener una carta.");
            Console.WriteLine("2) Si desea retirarse.");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 1)
                {
                    // n = n+1;
                /// <summary>
                /// Obtener carta aleatorias
                /// </summary>
                /// <returns>1 o 2</returns>
                
                    Random rnd = new Random();
                    int O_Cartas = rnd.Next(1, 12);
                    
                    Console.WriteLine("Tu carta vale: " + O_Cartas);
            

                    
                    }
                    

                }

        }
        



       



      


    }
