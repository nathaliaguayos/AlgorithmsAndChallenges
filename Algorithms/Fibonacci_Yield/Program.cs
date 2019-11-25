using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int x in Fibonacci(10))
            {
                Console.WriteLine(x);
            }
        }
        static IEnumerable<int> Fibonacci(int n)
        {
            for (int i=0, j=0, k=1;i<=n;i++)
            {
                yield return j;
                int temp = j + k;
                j = k;
                k = temp;

            }
        }
    }
}
