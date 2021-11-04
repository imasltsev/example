using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace example3
{
    public class Employee : Person
    {
       
        public Company Company { get; set; }

        /*     public Employee()
             {
                 GenerateCompany();
             }*/

        /*   private void GenerateCompany()
           {
                   var faker = new Faker<Company>("en")
                   .RuleFor(c => c.Name, f => f.Company.CompanyName())
                   .RuleFor(c => c.Country, f => f.Address.Country())
                   .RuleFor(c => c.City, f => f.Address.City())
                   .RuleFor(c => c.Address, f => f.Address.StreetAddress());

               _company = faker.Generate();
           }*/
        public override void Display()
        {
            base.Display();
            Console.WriteLine(
                $"{JobTitle} in \"{Company.Name}\" ({Company.Country}, {Company.City}, {Company.Address}) and my salary ${JobSalary}.");
        }
    }
}
