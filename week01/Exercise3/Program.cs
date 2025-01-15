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

        int guess = -1;

        while (guess != answer)
        {   
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > answer)
            {
                Console.WriteLine("Too high. Guess again.");
            }
        
            else if (guess < answer)
            {
                Console.WriteLine("Too low. Guess again");
            }

            else (guess == answer) 
            { 
                Console.WriteLine("You guessed it!");
            }
        }
    }
}