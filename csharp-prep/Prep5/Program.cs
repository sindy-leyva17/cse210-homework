using System;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage();
            string name = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(name, squaredNumber); 
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            return userName;
        } 

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int squareNumber = userNumber * userNumber; 
            return squareNumber;
        }

        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}"); 
        } 
         
    }
}
