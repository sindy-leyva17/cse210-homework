using System;

namespace prep3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int y = randomGenerator.Next(1, 101);

            int x = -1;

            while (x != y)
            {
                Console.WriteLine("What is you guess?");
                x = int.Parse(Console.ReadLine());

                if (y > x)
                {
                    Console.WriteLine("Higher");
                }
                else if (y < x)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }


            
        }
    }
}