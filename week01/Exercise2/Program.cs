<<<<<<< HEAD
=======
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their percentage grade
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -), unless it's A+ or F+/F-
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93)
        {
            sign = "-";  // Only A- is valid below 93
        }

        // Display final letter grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Check if the user passed or not
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working and you'll do better next time.");
        }
    }
}
>>>>>>> 8675ba7ef1fe90bb4b52779d97a094b65d496f86
