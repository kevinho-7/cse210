
//The user is not allowed to enter anything other than 'quit' or Enter.

using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("D&C", 4, 2);
        string text = "For God so loved the world that he gave his one and only Son";
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine($"{reference.GetDisplayText()}\n{scripture.GetDisplayText()}");

        while (!scripture.IsCompletelyHidden())
        {
            string input;
            do
            {
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
                input = Console.ReadLine().Trim();

                if (input != "" && input.ToLower() != "quit")
                {
                    Console.WriteLine("\nInvalid input! Please press Enter to continue or type 'quit' to exit.");
                }

            } while (input != "" && input.ToLower() != "quit");

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()}\n{scripture.GetDisplayText()}");
        }

        Console.WriteLine("\nAll words have been hidden!");
    }
}
