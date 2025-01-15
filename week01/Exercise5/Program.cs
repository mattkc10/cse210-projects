using System;

class Program
{
    static void Main()
    {
        static void Message(string[] args)
        {
            Console.WriteLine("Welcome to the program!");    
        }

        static string fullName(string first, string last)
        {
            Console.WriteLine("What is your first name?");
            string first = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();

            string name = first + last;
            return name;
        }
    Console.WriteLine(Message);
    Console.WriteLine(Name);
    }
    

}