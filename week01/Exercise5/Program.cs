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


    static string combineNames(string first, string last)
    {
        return first + "" + last;
    }
        Console.WriteLine(Message);
        Console.WriteLine(fullName);
    }
    

}