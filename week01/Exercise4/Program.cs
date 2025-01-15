using System;

using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumber = -1;
        while (newNumber != 0)
        {
            Console.Write("What number would you like to add to the list? (0 when finished) ");
            string userResponse = Console.ReadLine();
            newNumber = int.Parse(userResponse)

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.Write($"The sum of all your numbers is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of your numbers is {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.Write($"And the highest number is {max}");
    }
}