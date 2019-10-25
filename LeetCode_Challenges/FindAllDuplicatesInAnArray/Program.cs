using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllDuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var duplicates = nums.GroupBy(numbers => numbers).Where(numbers => numbers.Count() > 1)
                .Select(numbers => numbers.Key).ToList();

            duplicates.ForEach(Console.WriteLine);
            Console.Read();

        }
    }
}
