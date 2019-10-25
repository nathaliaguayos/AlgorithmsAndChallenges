using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacciSequence = new List<int>();

            Console.WriteLine("Enter the max value");
            int limit = Int32.Parse(Console.ReadLine());
            
            fibonacciSequence.Add(0);
            fibonacciSequence.Add(1);
            for (int index = 0; index <= limit; index++)
            {
                fibonacciSequence.Add(fibonacciSequence[index] + fibonacciSequence[index + 1]);
            }

            fibonacciSequence.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
