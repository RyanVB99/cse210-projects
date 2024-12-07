public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public void ShowAnimation(int seconds) {
            
        List<String> animationStrings =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        int waitTime = 1000;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(waitTime);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;

            }
        }
    }

   public void ShowCountdown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }
    }

    public void DisplayStartMessage() {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + " Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            SetDuration(duration);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(3);
        Console.Clear();
    }

    public void DisplayEndMessage() {
        Console.WriteLine("Well Done!!");
        ShowAnimation(5);
        Console.WriteLine();
        Console.WriteLine("You have completed another " + _duration + " seconds of " + _name + " activity.");
        ShowAnimation(5);
        Console.Clear();
    }

    protected void SetDuration(int duration) {
        _duration = duration;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
}