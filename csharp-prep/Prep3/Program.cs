using System;

namespace prep3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the magic number ?");
            string magicNumber = Console.ReadLine();

            int y = int.Parse(magicNumber);

            int x = 0;

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