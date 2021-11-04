using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace example3
{
    public class UserFactory
    {
        public UserFactory()
        { }
        public  void GeneratePerson(string person, List<Candidate> candidates, List<Employee> employees)
        {
            if (person == "Candidate")

            {
                CreatePerson<Candidate>(candidates);
            }
            else
            {
                CreatePerson<Employee> (employees);
            }

        }

        private void CreatePerson<T>(List<T> users) where T : Person
        {
            var faker = CreateFaker<T>();
            if (typeof(T) == typeof(Employee))
            {
                faker.RuleForType(typeof(Company), f => new Company()
                {
                    Name = f.Company.CompanyName(),
                    Country = f.Address.Country(),
                    City = f.Address.City(),
                    Address = f.Address.StreetAddress()
                });
            }

            users.Add(faker.Generate());
        }

        private Faker<T> CreateFaker<T>() where T : Person
        {
            var faker = new Faker<T>()
                .RuleFor(c => c.Id,f => Guid.NewGuid())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.JobTitle, f => f.Name.JobTitle())
                .RuleFor(c => c.JobDescription, f => f.Name.JobDescriptor())
                .RuleFor(c => c.JobSalary, f => f.Finance.Amount(50m, 10000m));
            return faker;
        }
    }
}   
