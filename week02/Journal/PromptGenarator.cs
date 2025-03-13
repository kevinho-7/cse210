public class PromptGenarator    
{
    public List<string> _prompts = new List<string>
        {
            "What made me smile today?",
            "What was a small moment of gratitude I experienced?",
            "How was I a positive influence on someone today?",
            "What challenge did I face, and how did I handle it?",
            "If I could relive one moment of the day, what would it be and why?",
            "What did I learn today that I can carry into the future?",
            "How did I show love or kindness to someone today?",
            "What was the best decision I made today?",
            "What could I have done differently to make my day even better?",
            "How did I feel peace or purpose in my day?"
        };


    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}