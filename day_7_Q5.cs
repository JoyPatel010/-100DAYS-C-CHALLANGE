using System;

namespace day_7_Q5
{
    internal class day_7_Q5
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int targetedNum = rnd.Next(1, 101);
            int guess;
            int attempt = 0;
            bool check = false;

            Console.WriteLine("Welcome to the Game of Guessing Number!");

            while(!check)
            {
                Console.Write("Enter a number to Guess : ");
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess > targetedNum)
                {
                    Console.WriteLine("Too High!, Try Again...");
                }else if(guess < targetedNum)
                {
                    Console.WriteLine("Too Low!, Try Again...");
                }
                else
                {
                    Console.WriteLine("Congratulatios!, yuo guesses the right number...");
                }

                check  = false;
            }

            Console.WriteLine("The number was: {0}", tar);

            Console.ReadLine();
           

            
        }
    }
}
