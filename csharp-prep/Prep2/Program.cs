using System;

namespace prep2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade percentage:");
            string valueFromUser = Console.ReadLine();

            int x = int.Parse(valueFromUser);

            string letter = "";

            if (x >= 90)
            {
                letter ="A";
            }
            else if (x >= 80)
            {
                letter ="B";
            }
            else if (x >= 70)
            {
                letter ="C";
            }
            else if (x >= 60)
            {
                letter ="D";
            }
            else 
            {
                letter ="F";
            }
            Console.WriteLine($"You got a {letter}");

            if (x >= 90 || x >= 80 || x >= 70)
            {
                Console.WriteLine("Congratulations, you pass.");
            }
            else{
                Console.WriteLine("Sorry , you do not pass.Good luck for the next one.");
            }
        }
    }
}