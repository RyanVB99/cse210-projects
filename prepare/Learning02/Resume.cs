namespace Learning02
{
    public class Resume
    {
        public string _name;
        public List<Job> _jobs;
        public List<string> _skills;
        public List<string> _certificates;

        public void Display()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Experience:");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
            Console.WriteLine("Skills:");
            foreach (string skill in _skills)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine("Certificates:");
            foreach (string certificate in _certificates)
            {
                Console.WriteLine(certificate);
            }
        }
    }
}