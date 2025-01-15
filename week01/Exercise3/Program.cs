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

        // We could also use a do-while loop here...
        while (answer != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (answer > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (answer < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}