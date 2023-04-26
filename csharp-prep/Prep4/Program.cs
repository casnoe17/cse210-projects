using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNum = -1;
        do
            {
                Console.Write("Enter a number (enter 0 to quit): ");
                string response = Console.ReadLine(); 
                userNum = int.Parse(response);
                if (userNum != 0)
                {
                    numbers.Add(userNum);
                }       
            }while(userNum !=0); 

        int sum = 0;
        foreach (int number in numbers)
            {
                sum += number;
            }

        float average = ((float)sum) / numbers.Count;

        int largestNumb = numbers[0];

        foreach(int number in numbers)
            {
                if (number > largestNumb)
                    {
                        largestNumb = number;
                    }
            }
        int smallestPositive = numbers.Where(number => number > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumb}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The list sorted is:");
        Console.WriteLine(string.Join("\n", numbers));
    }
}