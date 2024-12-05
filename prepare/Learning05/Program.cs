using System;

class Program
{
    static void Main(string[] args)
    {
        string studentName = "John";
        string topic = "Algebra";
        string textbookSection = "Chapter 3";
        string problems = "1-10";

        MathAssignment mathAssignment = new MathAssignment(studentName, topic, textbookSection, problems);

    Console.WriteLine(mathAssignment.GetSummary());
    Console.WriteLine(mathAssignment.GetHomeworkList());

    string title = "Writing Assignment 7";
    WritingAssignment writingAssignment = new WritingAssignment(studentName, topic, title);

    Console.WriteLine(writingAssignment.GetSummary());
    Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}