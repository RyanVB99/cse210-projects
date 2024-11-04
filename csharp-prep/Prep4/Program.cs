using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        int max = FindMax(numbers);
        int sum = CalculateSum(numbers);
        float average = CalculateAverage(numbers);

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }

    static int FindMax(List<int> numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static float CalculateAverage(List<int> numbers)
    {
        float average = (float)CalculateSum(numbers) / numbers.Count;
        return average;
    }
}