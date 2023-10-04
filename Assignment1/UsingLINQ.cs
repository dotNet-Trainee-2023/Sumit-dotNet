using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int salary { get; set; }

    }


    public class UsingLINQ
    {
        public void UsingLinq() {
            Console.WriteLine("LINQ process");

            List <PersonalDetails> people = new List<PersonalDetails>() { new PersonalDetails {Id = 1, Name = "Shyam" ,Age = 20, salary = 20000},
                new PersonalDetails {Id = 2, Name = "Hari" ,Age = 30, salary = 30000},
                new PersonalDetails {Id = 3, Name = "Sita" ,Age = 25, salary = 25000},
                new PersonalDetails {Id = 4, Name = "Rita" ,Age = 18, salary = 40000},
                new PersonalDetails {Id = 5, Name = "Kishore" ,Age = 40, salary = 45000},
                new PersonalDetails {Id = 6, Name = "Binod" ,Age = 25, salary = 33000},
                new PersonalDetails {Id = 7, Name = "Shankar" ,Age = 29, salary = 28000}
            };

            int totalNoOfPeople = people.Count();

            Console.WriteLine($"Total number of people in list: {totalNoOfPeople}");


            Console.WriteLine("List ordered by Age: ");
            IEnumerable<PersonalDetails> orderedByAge = people.OrderBy(x => x.Age);

            foreach (PersonalDetails person in orderedByAge)
            {
                Console.WriteLine($"{person.Id} {person.Name} {person.Age} {person.salary}");
            }

            Console.WriteLine("List ordered by Name: ");
            IEnumerable<PersonalDetails> orderedByName = people.OrderBy(x => x.Name);

            foreach (PersonalDetails person in orderedByName)
            {
                Console.WriteLine($"{person.Id} {person.Name} {person.Age} {person.salary}");
            }

            // Select only Name and Age from Person class and create a new List of PersonDetails class.

            var highestSalary = people.Max(x => x.salary);

            Console.WriteLine("Highest salary: "+highestSalary);

            var groupByAge = people.GroupBy(x => x.Age);

            Console.WriteLine("List grouped by age");
            foreach (var key in groupByAge)
            {
                foreach (var person in key)
                {
                    Console.WriteLine($"Key: {key.Key} Name: {person.Name} Age: {person.Age} Salary: {person.salary}");
                }
            }

            IEnumerable<PersonalDetails> salaryHigherThan25 = people.Where(x => x.salary > 25000);


            Console.WriteLine("People with salary higher than 25000");
            foreach (PersonalDetails person in salaryHigherThan25)
            {
                Console.WriteLine($"{person.Id} {person.Name} {person.Age} {person.salary}");
            }


            var onlyNames = people.Select(x => x.Name);

            Console.WriteLine("Only people names");
            foreach (var personName in onlyNames)
            {
                Console.WriteLine(personName);
            }
        }
    }
}
