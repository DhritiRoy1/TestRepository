using System;

namespace DuckDuckGoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter either 'Duck' or 'Goose', continuously pressing enter after each one.");
            Console.WriteLine("You must enter 'Duck' at least two times before entering 'Goose.'");
            String word = Console.ReadLine();
            int DuckCounter = 0;
            //int GooseCounter = 0;
            Boolean error = false;
            while (DuckCounter < 2|| word!="Goose")
            { 
                   if (word == "Duck")
                    {
                        DuckCounter++;
                        word = Console.ReadLine();
                    }
                    else if (word == "Goose"&& DuckCounter<2)
                    {
                        error = true;
                        Console.WriteLine("Error: Please enter 'Duck' at least 2 times before entering 'Goose'.");
                        DuckCounter = 0;
                        word = Console.ReadLine();
                        
                    }
                    else if (word == "Goose" && DuckCounter > 2)
                    {

                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("Error: Please enter either 'Duck' or 'Goose'");
                        DuckCounter = 0;
                        word = Console.ReadLine();
                        
                    }
             }
            if (!error)
            {
                Console.WriteLine("The game has ended. You played correctly!");
            }
            else
            {
                Console.WriteLine("The game has ended. ");
            }

        }



        }
}

          
