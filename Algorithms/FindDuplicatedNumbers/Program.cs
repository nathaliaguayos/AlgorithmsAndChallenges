using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 3, 2, 5 };

            var listOfDuplicated = numbers.GroupBy(number => number)
                .Where(numberCount => numberCount.Count() > 1)
                .Select(number => number.Key).ToList();
            
            listOfDuplicated.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
