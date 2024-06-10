using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guesses = 0;

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (guess == magicNumber)
        {
            guesses++;
            Console.WriteLine($"You guessed it in {guesses} try!");
        }
        else
        {
            while (guess != magicNumber)
            {
                guesses++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            
            guesses++;
            Console.WriteLine($"You guessed it in {guesses} try!");
        }
    }
}