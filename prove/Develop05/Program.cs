// Exceeding Requirements: I add a ProgressManager
// class that keeps track of currentScore, then
// used that to create a level uping system.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}

