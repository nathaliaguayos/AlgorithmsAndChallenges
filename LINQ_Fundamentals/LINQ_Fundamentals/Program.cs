using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Fundamentals.FirstExample;

namespace LINQ_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryExamples queryExamples = new QueryExamples();
            //queryExamples.FirstExample();
            queryExamples.RetrieveAllTheNamesWhichContainsA();
            Console.Read();
        }
    }
}
