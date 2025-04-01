using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Garro", "Fractions", "8.0", "8-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment write1 = new WritingAssignment("Rodrigo","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
                    
    }
}