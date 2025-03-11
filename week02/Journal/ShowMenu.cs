public class ShowMenu()
{
    string[] menu = { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };

    public void DisplayMenu()
    {
        string choice = "";

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

            if (getChoise == "1")
            {
                Console.WriteLine("Write");
            }
                else if (getChoise == "2")
            {
                Console.WriteLine("Display");
            }
                else if (getChoise == "3")
            {
                Console.WriteLine("Load");
            }
                else if (getChoise == "4")
            {
                Console.WriteLine("Save");
            }
        } 
    }                                    
}