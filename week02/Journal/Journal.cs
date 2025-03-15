using System.IO;

public class Journal
{
   public List<Entry> _entries = new List<Entry>();

   public void AddEntry(Entry newEntry)
   {
        _entries.Add(newEntry);
   }

   public void DisplayAll()
   {
     foreach(Entry en in _entries)
          {
            en.Display();
            Console.WriteLine();
          }
   }

   public void SaveToFile(string filename) 
   {
     using (StreamWriter outputFile = new StreamWriter(filename))
     {
            foreach (Entry en in _entries)
            {
               outputFile.WriteLine("Date: " + en._date + " - " + "Prompt: " + en._promptText);
               outputFile.WriteLine(en._entryText + "\n");
            }
     }
   }

   public void LoadFromFile(string filename)
   {
     string[] lines = System.IO.File.ReadAllLines(filename);

     foreach (string line in lines)
     {
            Console.WriteLine(line);
     }
   }

}
        