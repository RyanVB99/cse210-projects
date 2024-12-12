public class GoalManager {
    private List<Goal> goals;
    private int score;
    private int level;

    public GoalManager() {
        goals = new List<Goal>();
        score = 0;
        level = 1;
    }

    public void Start() {
        int choice = 0;
        while (choice != 6) {
            DisplayPlayerInfo();
            choice = DisplayMenu();
            switch (choice) {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    MarkComplete();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            if (choice == 6) {
                break;
            }
        }

    }

    public int DisplayMenu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return choice;
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine("You have " + score + " points.");
        Console.WriteLine("You are on level " + level + ".");
        Console.WriteLine();
    }

    public void ListGoalNames() {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++) {
            Console.WriteLine(i+1 + ". " + goals[i].DisplayString());
        }
        Console.WriteLine();
    }

    public void ListGoalDetails() {
        for (int i = 0; i < goals.Count; i++) {
            if (goals[i].IsComplete()) {
                Console.WriteLine(i+1 + ". " + "[X] " + goals[i].DisplayString());
            } 
            else {
                Console.WriteLine(i+1 + ". " + "[ ] " + goals[i].DisplayString());
            }
        }
        Console.WriteLine();
    }

    public void CreateGoal() {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        if (choice == 1) {
            goals.Add(new SimpleGoal(name, description, points));
        } else if (choice == 2) {
            goals.Add(new EternalGoal(name, description, points));
        } else if (choice == 3) {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int totalSteps = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            Console.WriteLine();
            goals.Add(new ChecklistGoal(name, description, points, totalSteps, bonusPoints));
        }
    }

    public void MarkComplete() {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        choice--;
        Console.WriteLine();
        int points = goals[choice].MarkComplete();
        Console.WriteLine("Congratulations! You have earned " + points + " points.");
        score += points;
        if (score >= 100 * level) {
            level = score / 100;
            Console.WriteLine("Congratulations! You have reached level " + level + "!");
        }
    }

    public void SaveGoals() {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        Console.WriteLine();
        File.WriteAllText(filename, string.Empty);
        using (StreamWriter writer = new StreamWriter(filename)) {
            writer.WriteLine(score);
            foreach (var goal in goals) {
                writer.WriteLine(goal.ConvertToString());
            }
        }
    }

    public void LoadGoals() {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        Console.WriteLine();

        using (StreamReader reader = new StreamReader(filename)) {
            score = int.Parse(reader.ReadLine());
            goals.Clear();
            while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                if (parts.Length == 4) {
                    bool isComplete = bool.Parse(parts[3]);
                    goals.Add(new SimpleGoal(name, description, points, isComplete));
                } else if (parts.Length == 3) {
                    goals.Add(new EternalGoal(name, description, points));
                } else if (parts.Length == 6) {
                    int totalSteps = int.Parse(parts[3]);
                    int amountCompleted = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    goals.Add(new ChecklistGoal(name, description, points, totalSteps, bonusPoints, amountCompleted));
                }
            }
        }
    }
}
