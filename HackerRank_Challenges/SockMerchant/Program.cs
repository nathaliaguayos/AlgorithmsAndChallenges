using System;
using System.IO;
using System.Linq;
/*
 * Given an array of integers representing the color of each sock, determine how many
 * pairs of socks with matching colors there are.
 * For example, there are n = 7 socks with colors ar={1,2,1,2,1,3,2} There is one pair of color
 * and one of color . There are three odd socks left, one of each color. The number of pairs is 2.
 */
namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int[] socks)
        {
            var socksGroup = socks.GroupBy(v => v);
            int result = 0;
            foreach (var group in socksGroup)
            {
                if (group.Count()>=2)
                {
                    result += group.Count() / 2;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of socks");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the colors of socks");
            int[] socks = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            Console.WriteLine("The number of socket pairs you would have is: ");
            Console.WriteLine(sockMerchant(socks));

            Console.Read();
        }
    }
}
