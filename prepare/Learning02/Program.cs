using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobInfo1 = new Job();
        jobInfo1._company = "Microsoft";
        jobInfo1._jobTitle = "Software Engineer";
        jobInfo1._startYear = 2019;
        jobInfo1._endYear = 2022;

        Job jobInfo2 = new Job();
        jobInfo2._company = "Apple";
        jobInfo2._jobTitle = "Manager";
        jobInfo2._startYear = 2022;
        jobInfo2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(jobInfo1);
        myResume._jobs.Add(jobInfo2);

        myResume.displayResume();
    }
}