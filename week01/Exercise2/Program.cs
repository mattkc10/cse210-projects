using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your GPA %.");
        string gradeFromUser = Console.ReadLine();

        int percent = int.Parse(gradeFromUser);
       
        string letterGrade = "";


        if (percent > 90)
        {
            letterGrade = "A";
        }
        else if (percent > 79 && percent < 90)
        {
            letterGrade = "B";
        }
        else if (percent > 69 && percent < 80)
        {
            letterGrade = "C";
        }
        else if (percent > 60 && percent < 70)
        {
            letterGrade = "D";
        }
        else if (percent < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your Grade is : {letterGrade}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}