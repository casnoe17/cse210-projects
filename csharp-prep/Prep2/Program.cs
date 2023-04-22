using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade Percentage you earned? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);
        string letter = "";
        string plusOrMinus = "";

        if (gradePercent >= 90)
            {
                letter = "A";
            }
        else if (gradePercent >= 80 && gradePercent <= 89)
            {
                letter = "B";
            }
        else if (gradePercent >= 70 && gradePercent <= 79)
            {
                letter = "C";
            }
        else if (gradePercent >= 60 && gradePercent <=69)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }

        if (gradePercent < 97)
            {
                if (gradePercent % 10 >= 7)
                    {
                        plusOrMinus = "+";
                    }
                else if (gradePercent % 10 <= 3)
                    {
                        plusOrMinus = "-";
                    }
            }
        if (gradePercent <= 50)
            {
                plusOrMinus = "";
            }
        
        Console.WriteLine($"Your Letter grade is {letter}{plusOrMinus}.");
        
        if (gradePercent >= 70)
            {
                Console.WriteLine("You Passed!");
            }
        
    }
}