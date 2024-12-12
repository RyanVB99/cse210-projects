using System;
using System.IO;

// For the stretch goal, I implemented a "level" system that increases as the player completes goals.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
        
}
