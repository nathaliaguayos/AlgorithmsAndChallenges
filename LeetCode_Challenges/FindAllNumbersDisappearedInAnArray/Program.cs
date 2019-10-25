using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllNumbersDisappearedInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            int index = 1;
            Array.Sort(nums);
            //nums.ToList().ForEach(Console.WriteLine);
            List<int> missingNumbers = new List<int>();

            int larger = nums[0];
            foreach (var num in nums)
            {
                if (num > larger)
                {
                    larger = num;
                }
            }

            do
            {
                if (!nums.Contains(index) && !missingNumbers.Contains(index))
                {
                    missingNumbers.Add(index);
                }

                index += 1;
            } while (index!=larger);
            Console.WriteLine("missing numbers\n");
            missingNumbers.ForEach(Console.WriteLine);
            Console.Read();
        }
    }
}
