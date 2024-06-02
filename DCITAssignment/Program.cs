using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Grade");
            Console.WriteLine("2. Calculate Ticket Price");
            Console.WriteLine("3. Identify Triangle Type");
            Console.WriteLine("4. Exit");
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
                        CalculateTicketPrice();
                        break;
                    case 3:
                        IdentifyTriangleType();
                        break;
                    case 4:
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

    static void CalculateTicketPrice()
    {
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
            }
            else
            {
                ticketPrice = 10;
            }

            Console.WriteLine("The ticket price is: GHC" + ticketPrice);
        }
        else
        {
            Console.WriteLine("Error: Please enter a numerical age.");
        }
    }

    static void IdentifyTriangleType()
    {
        Console.Write("Enter the length of the first side of the triangle: ");
        string side1Input = Console.ReadLine();

        Console.Write("Enter the length of the second side of the triangle: ");
        string side2Input = Console.ReadLine();

        Console.Write("Enter the length of the third side of the triangle: ");
        string side3Input = Console.ReadLine();

        if (double.TryParse(side1Input, out double side1) &&
            double.TryParse(side2Input, out double side2) &&
            double.TryParse(side3Input, out double side3))
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Error: The lengths of the sides must be positive numbers.");
                return;
            }

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter numerical values for the sides.");
        }
    }
}



