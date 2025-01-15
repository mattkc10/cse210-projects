using System;

class Program
{
    static void Main()
    {
        static void Message(string[] args)
        {
            Console.WriteLine("Welcome to the program!");    
        }

    Console.WriteLine("What is your first name?");
    string first = Console.ReadLine();

    Console.WriteLine("What is your last name?");
    string last = Console.ReadLine();

    string fullName = combineNames(first, last);

    Console.WriteLine("Please tell me which is your favorite number. ");
    double number = Convert.ToDouble(Console.ReadLine()); 
    double result = GetSquareRoot(number); 
    
    
    
    static string combineNames(string first, string last)
    {
        return first + "" + last;
    }

    static double GetSquareRoot(double number)
    {
        return Math.Sqrt(number);
    }

    Console.WriteLine(Message);
    Console.WriteLine(fullName);
    Console.WriteLine("The square root of " + number + " is: " + result); 
    }
    

}