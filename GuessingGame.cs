using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameHints
{

    
    class Program
    {

        static int userInput;
        static int Guesses;
        static void Main(string[] args)
        {
            // Console.ReadLine() takes in next line typed
            // by the user in the console
            Random rand = new System.Random();
            int number = rand.Next(100);
            Console.Write("You will play a guessing game, where you'll have to guess a number from one to 100 ");
            Console.Write("You will will have 10 guesses ");
            Console.WriteLine("Guess a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            // Console.ReadLine() takes in next line typed
            // by the user in the console. Conver.ToInt32 converts the number in string format to an integer

            Guesses = 1;
            // This while loop runs until the user guesses the number or runs out of guess
            while (userInput != number&&Guesses<10)
            {
                /*The conditionals allow for the right method to be printed dependining on if the guess 
                 is higher or lower than the number*/
                if (userInput < number)
                {
             
                    GuessMessagePrinterAndIncreaser("higher");
                }
                else if (userInput > number)
                {
                    GuessMessagePrinterAndIncreaser("lower");
                }
                
            
            }
            if (Guesses < 10)
            {
                Console.WriteLine(number+" was the anwser!");
            }
            else
            {
                Console.WriteLine("You're out of Guesses!");
                Console.WriteLine("The anwser was "+number+" ");
            }

        }
        //This method will print the right message taking strings higer or lower as parameters
        static void GuessMessagePrinterAndIncreaser(String word)
        {
            Console.WriteLine("The anwser is " + word + " than " + userInput + " ");
            userInput = Convert.ToInt32(Console.ReadLine());
            // Guess increases each time in order to count the number of guesses made by the user
            Guesses++;
        }
    }
}
