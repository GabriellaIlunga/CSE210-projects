//Dynamic Leveling System: I implemented a ranking hierarchy (Beginner, Goal Crusher, High Achiever, and Eternal Master) that updates dynamically in the DisplayPlayerInfo method based on the user's total score. This adds a gamification layer beyond the basic point tracking.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager questManager = new GoalManager();

        questManager.Start();
    }
}