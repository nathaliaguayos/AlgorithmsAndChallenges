using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Fundamentals.FirstExample
{
    public class QueryExamples
    {
        private String[] instructors = {"Aaron", "Fritz", "Scott", "Keith"};

        public void FirstExample()
        {
            IEnumerable<String> query = from s in instructors
                where s.Length == 5
                orderby s descending
                select s;

            foreach (var entry in query)
            {
                Console.WriteLine(entry);
            }
        }

        public void RetrieveAllTheNamesWhichContainsA()
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                where name.Contains('a')
                select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }

    }
}
