using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());
        string quantifier = DeterminePlusOrMinus(gradePercentage);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your grade is an A" + quantifier + ".");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your grade is a B" + quantifier + ".");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your grade is a C" + quantifier + ".");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your grade is a D" + quantifier + ".");
        }
        else
        {
            Console.WriteLine("Your grade is an F" + quantifier + ".");
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass this time. Keep trying!");
        }
    }

    static string DeterminePlusOrMinus(int gradePercentage)
    {
        if (gradePercentage < 60)
        {
            return "";
        }

        else if (gradePercentage % 10 >= 7)
        {
            if (gradePercentage <= 90)
            {
                return "+";
            }
            else
            {
                return "";
            }
        }
        else if (gradePercentage % 10 <= 3)
        {
            return "-";
        }
        else
        {
            return "";
        }
    }
}