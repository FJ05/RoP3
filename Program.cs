using System;

namespace XY_rectangle_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //fråga användaren om ett x värde och gör det sendan till en int
            Console.WriteLine("Ange ditt x värde");
            int Xvärde = Convert.ToInt32(Console.ReadLine());

            //fråga användaren om ett y värde och gör det sendan till en int
            Console.WriteLine("Ange ditt y värde");
            int Yvärde = Convert.ToInt32(Console.ReadLine());

            //for loop som skriver ut höjden
            for (int uppräkningFörY = 0; Yvärde > uppräkningFörY; uppräkningFörY++) 
            {
                //for loop som skriver ut brädden
                for (int uppräkningFörX = 0; Xvärde > uppräkningFörX; uppräkningFörX++)
                {
                    //skriver ut rektanglarna
                    Console.Write("#");
                }
                //minskar antelet på x raden med -1 per rad
                Xvärde--;
                //skapar en ny rad
                Console.WriteLine();
            }
        }
    }
}
