using System;
using System.Collections.Generic;

// To show creativity I made the reflection activity ensure not to repeat the same question twice, unless all questions have been asked.

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        Menu();
        string choice = Console.ReadLine();
        while (choice != "4")
        {
            switch (choice)
            {
                case "1":
                    breathingActivity.Run();
                    break;
                case "2":
                    reflectionActivity.Run();
                    break;
                case "3":
                    listingActivity.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Menu();
            choice = Console.ReadLine();
        }

    }

    static void Menu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write ("Select a choice from the menu: ");
    }


}