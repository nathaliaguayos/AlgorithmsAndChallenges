using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsNumbers_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the max");
            int limit = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= limit; i++)            
            {
                if (i!=0 && i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
