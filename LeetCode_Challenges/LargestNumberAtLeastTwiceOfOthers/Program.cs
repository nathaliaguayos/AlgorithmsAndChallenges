using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberAtLeastTwiceOfOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] {3,6,1,0}; //1
            //int[] array = new[] { 1, 2, 3, 4 }; //-1
            //int[] array = new[] {1};//0

            Console.WriteLine(FindTheLargestNumber(array).index);
            Console.Read();
        }

        static LargestElement FindTheLargestNumber(int[] array)
        {
            LargestElement largest = new LargestElement();
            largest.value = array[0];
            largest.index = 0;
            
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > largest.value)
                {
                    largest.value = array[index];
                    largest.index = index;
                }
            }

            foreach (var item in array)
            {
                if (largest.value != item && (largest.value / 2) < item)
                {
                    largest.index = -1;
                    return largest;
                }
            }
            return largest;
        }

        public struct LargestElement
        {
            public int value;
            public int index;
        }
    }
}
