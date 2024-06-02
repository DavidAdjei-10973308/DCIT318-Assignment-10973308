using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Grade");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice (1-4): ");
            string choiceInput = Console.ReadLine();

            if (int.TryParse(choiceInput, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CalculateGrade();
                        break;
                    case 2:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a numerical choice.");
            }

            Console.WriteLine();
        }
    }

    static void CalculateGrade()
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string gradeInput = Console.ReadLine();

        if (int.TryParse(gradeInput, out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                Console.WriteLine("The letter grade is: " + letterGrade);
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a numerical grade.");
        }
    }
}
