using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Kevin G. Ferreira");
        assignment1.SetTopic("Math");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        Assignment assignment2 = new Assignment();
        assignment2.SetStudentName("Jobert");
        assignment2.SetTopic("Portuguese");
        Console.WriteLine(assignment2.GetSummary());
        
        
    }
} 