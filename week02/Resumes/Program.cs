using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();
      job1._company = "Microsoft";
      job1._jobTitle = "Software Engineer";
      job1._startYear = 2019;
      job1._endYear = 2022;

      Job job2 = new Job();
      job2._company = "Apple";
      job2._jobTitle = "Manager";
      job2._startYear = 2017;
      job2._endYear = 2019; 

      Resume person1 = new Resume();
      person1._name = "Allison Rose";

      person1._jobs.Add(job1);
      person1._jobs.Add(job2);

      person1.DisplayResume();
      
    }
}