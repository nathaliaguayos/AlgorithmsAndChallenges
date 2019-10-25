using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            List<int> primes = new List<int>();
            List<int> NoPrimes = new List<int>();
            Console.WriteLine("Enter de target max number to find primes numbers");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= limit; currentNumber++)
            {
                counter = 0;
                for (int divisor = 1; divisor <= currentNumber; divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        counter++;
                    }
                }

                if (counter != 2)
                {
                    primes.Add(currentNumber);
                }
                else
                {
                    NoPrimes.Add(currentNumber);
                }               
            }

            Console.WriteLine("Prime numbers from 1 to " + limit);
            primes.ForEach(Console.WriteLine);

            Console.WriteLine("\nNo prime numbers from 1 to " + limit);
            primes.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
    
}
