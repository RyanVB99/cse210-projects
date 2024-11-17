using System;
using System.Runtime.CompilerServices;
using System.IO;

/* I added a "Mood" attribute to my Entry class that allows the user to track their mood for the day
in each entry. */

class Program
{
    static void Main()
    {
        int choice;
        string filename;
        string prompt;
        string mood;
        Journal journal = new Journal();

        DisplayMenu();
        choice = int.Parse(Console.ReadLine());
        while (choice != 5)
        {
            switch (choice)
            {
                case 1:
                    prompt = PromptGenerator.SelectPrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("Please enter your response: ");
                    string response = Console.ReadLine();
                    Console.WriteLine("Please enter your mood: ");
                    mood = Console.ReadLine();
                    journal.AddEntry(response, prompt, mood);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.WriteLine("Please enter the filename: ");
                    filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                case 4:
                    Console.WriteLine("Please enter the filename: ");
                    filename = Console.ReadLine();
                    journal.Save(filename);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());
        }

    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
    }

}