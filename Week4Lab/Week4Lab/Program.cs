using System;
using System.Collections.Generic;
using System.Linq;

namespace Week4Lab
{
    class Program
    {
        static void Print<T>(string label, IEnumerable<T> results)
        {
            Console.WriteLine(label);
            foreach (var result in results)
                Console.WriteLine("\t{0}", result);
        }

        static void Main(string[] args)
        {
            Company c = new Company();

            // 1. List the names of the employees who do not have a supervisor.
            // The results should combine FirstName and LastName into one string.

            // 2. List the last names of the employees whose last name starts with D.
            // The results should be listed in alphabetic order without duplicates.

            // 3. List the names of the employees who are on the project Blue.
            // The results should combine FirstName and LastName into one string.

            // 4. Find Jane Doe's subordinates, i.e. the employees who are supervised by Jane Doe.

            // 5. Find the employee(s) who were hired in 2015 and worked on the project Blue.
        }
    }
}
