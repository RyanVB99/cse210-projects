using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("2023-10-01", 30, 5);
        Cycling cycling = new Cycling("2023-10-02", 60, 20);
        Swimming swimming = new Swimming("2023-10-03", 45, 30);

        Console.WriteLine("Running:");
        running.GetSummary();
        Console.WriteLine("Cycling:");
        cycling.GetSummary();
        Console.WriteLine("Swimming:");
        swimming.GetSummary();
    }
}