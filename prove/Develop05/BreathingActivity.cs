public class BreathingActivity : Activity
{
    public void Run() {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) {
            Console.Write("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndMessage();
    }

    public BreathingActivity() : base("Breathing", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 60)
    {

    }
}