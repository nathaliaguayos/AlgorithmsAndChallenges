using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 0 };
            int smallest = numbers[0], largest = numbers[0];

            foreach (var number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }

                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.ReadLine();
        }
    }
}
