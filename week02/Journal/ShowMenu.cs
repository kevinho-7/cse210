public class ShowMenu
{
    string[] menu = { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };

    public void DisplayMenu()
    {
        string choice = "";

        Journal journal = new Journal();

        while(choice != "5")
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Welcome to the Journal App!!");
            Console.WriteLine("Please select one of the following choices");
        
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("What would you like to do? - "); string getChoise = Console.ReadLine();

            choice = getChoise;

            PromptGenarator prompts =  new PromptGenarator();
            Entry entries = new Entry();

            if (getChoise == "1")
            {
                Console.WriteLine();
                string randomPrompt = prompts.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                entries._promptText = randomPrompt;
                Console.Write("> "); 
                entries._entryText = Console.ReadLine();
                journal.AddEntry(entries);
            }
                else if (getChoise == "2")
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
                else if (getChoise == "3")
            {
                Console.WriteLine();
                Console.WriteLine("What's the filename?");
                Console.Write("> "); 
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
                else if (getChoise == "4")
            {
                Console.WriteLine();
                Console.WriteLine("What's the filename?");
                Console.Write("> "); 
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }   
    }                                    
}