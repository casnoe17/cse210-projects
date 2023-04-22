using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "yes";
                int counter = 0;

        while (again == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0,100);
            int guess = -1;

            do
                {
                    Console.Write("What is your guess? ");
                    string numGuess = Console.ReadLine();
                    guess = int.Parse(numGuess);
                    if (guess < number)
                        {
                            Console.WriteLine("Higher");
                        }
                    else if (guess > number)
                        {
                            Console.WriteLine("Lower");
                        }
                    else
                        {
                            Console.WriteLine("You chose Correct!");
                        }
                    counter += 1;
                } while (guess != number);

            Console.WriteLine($"You took {counter} tries.");
            Console.Write("Would you like to play again? ");
            again = Console.ReadLine();
        }

    }
}