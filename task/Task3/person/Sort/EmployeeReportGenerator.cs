using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    public class EmployeeReportGenerator : IReportGenerator
    {
        public void SortEmployee(List<Employee> employees)
        {
            var users = new List<object>();
            for (int i = 0; i < employees.Count; i++)
            {
                users.Add(employees[i]);
            }

            SortUser(users);
        }

        public void SortUser(List<object> users)
        {
            var employees = new List<Employee>();
            for (int i = 0; i < users.Count; i++)
            {
                employees.Add((Employee)users[i]);
            }

            employees.Sort((a, b) => a.Company.Name.CompareTo(b.Company.Name));// sort by Company


            for (int i = 0; i < employees.Count; i++)     // we sort by wages if the companies are the same.
            {
                var tmp = new Employee();

                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (j == employees.Count)
                    {
                        break;
                    }

                    if (employees[i].Company.Name.Equals(employees[j].Company.Name))
                    {
                        if (employees[i].JobSalary < employees[j].JobSalary)
                        {
                            tmp = employees[i];
                            employees[i] = employees[j];
                            employees[j] = tmp;
                            tmp = null;
                        }
                    }
                }
            }

            Console.WriteLine("\nSorted Employees:");
            foreach (var user in employees)
            {
                Console.WriteLine($"{user.Id} | {user.Company.Name,40} | {user.FullName,25} | ${user.JobSalary}");
            }
        }
    }
}
