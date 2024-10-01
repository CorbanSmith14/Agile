using System;

class Program
{
    static void Main()
    {
        string studentName;
        int score;

        Console.WriteLine("Enter student name:");
        studentName = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Enter student score (0-100):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out score) && score >= 0 && score <= 100)
                break;

            Console.WriteLine("Invalid score. Please enter a valid score between 0 and 100.");
        }
        string grade;
        if (score >= 90)
            grade = "A";
        else if (score >= 80)
            grade = "B";
        else if (score >= 70)
            grade = "C";
        else if (score >= 60)
            grade = "D";
        else
            grade = "F";

        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Grade: " + grade);

        Console.ReadLine();
    }
}