using System;

namespace prep3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the magic number ?");
            string magicNumber = Console.ReadLine();

            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();

            int x = int.Parse(guess);
            int y = int.Parse(magicNumber);

            if (x > y)
            {
                Console.WriteLine("Lower");
            }
            else if (x < y)
            {
                Console.WriteLine("Higher")
            }
            else
            {
                Console.WriteLine("You get it")
            }
            
        }
    }
}