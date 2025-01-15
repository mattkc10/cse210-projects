using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lets play a game. Tell me what the magic number is?");
        string answerGiven = Console.ReadLine();

        int answer = int.Parse(answerGiven);


        Console.WriteLine("Now guess a number.");
        string guessGiven = Console.ReadLine();

        int guess = int.Parse(guessGiven);

        while (guess != answer)
        {   
            if (guess > answer)
            {
                Console.WriteLine("Too high. Guess again.");
                string guessGiven = Console.ReadLine();

                int guess = int.Parse(guessGiven);
            }
        
            if (guess < answer)
            {
                Console.WriteLine("Too low. Guess again");
                string guessGiven = Console.ReadLine();

                int guess = int.Parse(guessGiven);
            }

            if (guess == answer) 
            { 
                Console.WriteLine("You guessed it!");
            }
        }
    }
}