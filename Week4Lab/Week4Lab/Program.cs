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

            var r1 = from e in c.Employees 
                     where e.SupervisorId is null 
                     select (e.FirstName , e.LastName);
            Print("Q1 (query)", r1);

            // 2. List the last names of the employees whose last name starts with D.
            // The results should be listed in alphabetic order without duplicates.

            var r2 = c.Employees
                .Where(e => e.LastName.StartsWith("D"))
                .OrderBy(e => e.LastName)
                .Select(e => e.LastName)
                .Distinct();
            Print("Q2 (method)", r2);

            // 3. List the names of the employees who are on the project Blue.
            // The results should combine FirstName and LastName into one string.

            var res = from e in c.Employees
                      join p in c.Projects
                      on e equals p.Leader
                      where p.Name == "Blue" && p.Members.Contains(e)
                      select (e.FirstName, e.LastName);

            Print("Q3 (query)", res);

            // 4. Find Jane Doe's subordinates, i.e. the employees who are supervised by Jane Doe.

            var r4 = from e1 in c.Employees
                     join e2 in c.Employees
                     on e1.SupervisorId equals e2.Id
                     where e2.FirstName == "Jane" && e2.LastName == "Doe"
                     select e1;
            Print("Q4 (query", r4);

            // 5. Find the employee(s) who were hired in 2015 and worked on the project Blue.

            var r5 = (from p in c.Projects where  p.Name ==  "Blue" select p.Members)
                .Single()
                .Intersect(from e in c.Employees where e.DateHired.Year == 2015 select e);
            Print("Q5 (query)", r5);
               
        }
    }
}
