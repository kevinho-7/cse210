using System;

class Program
{
    static void Main(string[] args)
    {
        // For the 'Show creativity', the user is not allowed to type anything different from the options. If they try, an error message will appear.

        GoalManager gol = new GoalManager();
        gol.Start();
    }
}