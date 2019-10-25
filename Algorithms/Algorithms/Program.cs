using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //String string1 = "Malayalam";
            Console.WriteLine("Enter a string to analyze");
            String string1 = Convert.ToString(Console.ReadLine());
            char[] chararray = string1.ToCharArray();
            Array.Reverse(chararray);
            String string2 = new String(chararray);

            if (string1.Equals(string2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Palindrome! ");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }

            Console.Read();
        }
    }
}
