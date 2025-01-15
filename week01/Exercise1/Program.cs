using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.WriteLine("What is your favorite first name?");
        string first = Console.ReadLine();
        Console.WriteLine("What is your favorite last name?");
        string last = Console.ReadLine();
        Console.Write($" Your name is {first} {last}");
    }
}