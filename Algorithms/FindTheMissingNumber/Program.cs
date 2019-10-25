using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the missing number applying the formula: n(n+1)/2
            int n = 10;
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 10};
            int currentSum = 0;
            int expectedSum = n * (n + 1) / 2;

            foreach (var number in numbers)
            {
                currentSum += number;
            }
            Console.WriteLine("The missing number is: "+(expectedSum-currentSum));
            Console.ReadLine();
        }
    }
}
