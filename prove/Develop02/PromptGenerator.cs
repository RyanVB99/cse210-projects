using Random = System.Random;

class PromptGenerator {
    static PromptGenerator() {
        _prompts = new List<string> {
            "What was the best part of your day?",
            "What did you learn today?",
            "What are you grateful for today?",
            "Describe a challenge you faced today.",
            "What made you smile today?"
        };
    }

    public static string SelectPrompt() {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public static List<string> _prompts;
}