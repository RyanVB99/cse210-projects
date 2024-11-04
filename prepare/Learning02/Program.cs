using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2018;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Product Manager";
        job2._startYear = 2018;
        job2._endYear = 2020;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Allison Rose";
        resume._jobs = new List<Job> { job1, job2 };
        resume._skills = new List<string> { "C#", "JavaScript", "Python" };
        resume._certificates = new List<string> { "Microsoft Certified: Azure Fundamentals", "Google Certified: Associate Cloud Engineer" };
        resume.Display();
    }
}