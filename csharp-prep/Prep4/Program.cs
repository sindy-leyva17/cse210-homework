using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            List<int> numbers = new List<int>();
            int number;

            do
            {
                Console.WriteLine("Enter a number:");
                number = int.Parse(Console.ReadLine());
                
                if (number != 0)
                {
                    numbers.Add(number);
                }
            } while (number != 0);
            
            int sum = 0;
            
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum is: {sum}");
            
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            
            int max = int.MinValue; 

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
            
            
        }
    }
}
