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
        else if (percent > 79 && x < 90)
        {
            letterGrade = "B";
        }
        else if (percent > 69 && x < 80)
        {
            letterGrade = "C";
        }
        else if (percent > 60 && x < 70)
        {
            letterGrade = "D";
        }
        else if (percent < 60)
        {
            letterGrade = "F";
        }
    }
}