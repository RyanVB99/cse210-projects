public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run() {
        int count = 0;
        DisplayStartMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine("You listed " + count + " items!");

        DisplayEndMessage();
    }

    string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    void DisplayPrompt(string prompt) {
        Console.WriteLine("--- " + prompt + " ---");
    }

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60)
    {

    }
}