using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
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
            Console.WriteLine("--Welcome to the Mindfulness Program!--\n");
            Console.WriteLine("Menu options:");
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                BreathingActivity b1 = new BreathingActivity(
                    "Breathing", 
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    0
                );
                b1.Run();
            }

            else if (choice == "2")
            {
                Console.WriteLine("2");
                ListingActivity listing = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    0
                );
                listing.Run();
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