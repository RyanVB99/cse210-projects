using System;
using Random = System.Random;

//Added the ability to select from several scriptures or enter a custom one.

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = StartGame();
        Memorize(scripture);
    }

    static Scripture StartGame()
    {
        int choice;
        choice = GetReference();
        Scripture scripture = GetScripture(choice);
        Console.Clear();
        scripture.GetDisplayText();
        return scripture;

    }

    static void Memorize(Scripture scripture)
    {
        while (!scripture.IsFullyHidden())
        {
            Console.WriteLine("Press enter to continue. Type 'quit' to exit.");
            string input = Console.ReadLine();
            Console.Clear();
            int numberToHide = new Random().Next(1, 9);
            scripture.HideRandomWords(numberToHide);
            scripture.GetDisplayText();
            if (input == "quit" || scripture.IsFullyHidden())
            {
                break;
            }
        }
    }

    static int GetReference()
    {
        Console.WriteLine("Select a scripture or enter your own:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Romans 3:23");
        Console.WriteLine("3. Alma 32:21");
        Console.WriteLine("4. Enter your own");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static Scripture GetCustomScripture()
    {
        Console.WriteLine("Enter the book:");
        string book = Console.ReadLine();
        Console.WriteLine("Enter the chapter:");
        string chapter = Console.ReadLine();
        Console.WriteLine("Enter the verse:");
        string verse = Console.ReadLine();
        Console.WriteLine("Enter the text:");
        string text = Console.ReadLine();
        return new Scripture(new Reference(book, int.Parse(chapter), int.Parse(verse)), text);
    }

    static Scripture GetScripture(int choice)
    {
        if (choice == 1)
        {
            return new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }
        else if (choice == 2)
        {
            return new Scripture(new Reference("Romans", 3, 23), "For all have sinned, and come short of the glory of God;");
        }
        else if (choice == 3)
        {
            return new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        }
        else
        {
            return GetCustomScripture();
        }
    }
}