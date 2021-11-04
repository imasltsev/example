using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persons = { "Employee", "Candidate" };

            Random rnd = new Random();
            int maxValueOfPerson = rnd.Next(25);
            var personfactory = new UserFactory();
            var employees = new List<Employee>();
            var candidates = new List<Candidate>();
          
            for (int i = 0; i < maxValueOfPerson; i++)
            {
                personfactory.GeneratePerson(persons[rnd.Next(2)], candidates, employees);
            }
            foreach(var person in employees)
            {
                person.Display();
                Console.WriteLine();
            }
            foreach(var person in candidates)
            {
                person.Display();
                Console.WriteLine();
            }
            var erg = new EmployeeReportGenerator();
            erg.SortEmployee(employees);

            var crg = new CandidateReportGenerator();
            crg.SortCandidate(candidates);
        }
    }
}
