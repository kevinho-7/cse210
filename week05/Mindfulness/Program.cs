using System;

class Program
{
    static void Main(string[] args)
    {
        string[] menu = new string[4] 
        {
            "   1. Start breathing activity",
            "   2. Start reflecting activity",
            "   3. Start listing activity",
            "   4. Quit"
        };

        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!\n");
            Console.WriteLine("Please select an activity from the menu below:");
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.WriteLine("1");
                // BreathingActivity breathingActivity = new BreathingActivity();
                // breathingActivity.Start();
            }
            else if (choice == "2")
            {
                Console.WriteLine("2");
                // ReflectingActivity reflectingActivity = new ReflectingActivity();
                // reflectingActivity.Start();
            }
            else if (choice == "3")
            {
                Console.WriteLine("3");
                // ListingActivity listingActivity = new ListingActivity();
                // listingActivity.Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("--Invalid choice. Please try again.--\n");
            }
        }
        Console.WriteLine("Thank you for using the Mindfulness Program. Have a great day!");

    }
}