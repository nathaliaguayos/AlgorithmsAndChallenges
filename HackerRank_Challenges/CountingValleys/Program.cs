using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Char[] s = new Char[] {'U', 'D', 'D', 'D', 'U', 'D', 'U', 'U' }; //1
            //Char[] s = new Char[] { 'D', 'D', 'U', 'U', 'U', 'U', 'D', 'D' };//2

            //Console.WriteLine("Enter the array size");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the steps array");
            string s = Console.ReadLine();

            FirstSolution firstSolution = new FirstSolution();
            Console.WriteLine(firstSolution.countingValleys(n, s));

            //SecondSolution secondSolution = new SecondSolution();
            //Console.WriteLine(secondSolution.countingValleys(n,s));


            Console.Read();
        }
        
    }
}
