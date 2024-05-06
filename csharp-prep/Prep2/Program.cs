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

            if (x >= 90)
            {
                Console.WriteLine("You got an A");
            }
            else if (x >= 80)
            {
                Console.WriteLine("You got a B");
            }
            else if (x >= 70)
            {
                Console.WriteLine("You got a C");
            }
            else if (x >= 60)
            {
                Console.WriteLine("You got a D");
            }
            else if (x < 60)
            {
                Console.WriteLine("You got a F");
            }
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