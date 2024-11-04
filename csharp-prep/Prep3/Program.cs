using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 20);
        int guess = -1;
        int attempts = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
                Console.WriteLine("It took you " + attempts + " attempts.");
                Console.WriteLine("Would you like to play again? (yes/no)");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    magicNumber = random.Next(1, 20);
                    guess = -1;
                    attempts = 0;
                }
            }
        }
    }
}