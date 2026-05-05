using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Northrop";
        job1._startYear = 2001;
        job1._endYear = 2026;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Truck Washer";
        job2._company = "Modern Maintainence";
        job2._startYear = 2017;
        job2._endYear = 2026;
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Cam Smith";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
        

    }
}