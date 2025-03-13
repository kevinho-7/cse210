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
        }
   }

   public void SaveToFile() 
   {

   }

   public void LoadFromFile()
   {

   }

}