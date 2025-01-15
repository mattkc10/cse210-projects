using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your GPA as a whole number.");
        string gradeFromUser = Console.ReadLine();

        int x = int.Parse(gradeFromUser);

        if (x < 90)
        {
            Console.WriteLine("This is an A or higher!");
            Console.WriteLine("Great job! You are passing!");
        }
        else if (x < 79 && x > 90)
        {
            Console.WriteLine("This is an B grade!");
            Console.WriteLine("Great job! You are passing!");
        }
        else if (x < 69 && x > 80)
        {
            Console.WriteLine("This is at a C.");
            Console.WriteLine("Great job! You are passing!");
        }
        else if (x < 60 && x > 70)
        {
            Console.WriteLine("This is a D grade.");
            Console.WriteLine("You do not have a passing grade. Work hard, you can do it!");
        }
        else if (x > 60)
        {
            Console.WriteLine("This is a F grade.");
            Console.WriteLine("You do not have a passing grade. Work hard, you can do it!");
        }
    }
}