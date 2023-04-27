using System;

class Program
{
    static void Main(string[] args)
        {
            WelcomeMessage();
            string userName = PromptUserName();
            int userNum = PromptUserNumber();
            int numberSquare = SquareNumber(userNum);
            DisplayResult(userName , numberSquare);
        }   
    static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;    
        }
    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
    static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {number}.");
        }
}