// See https://aka.ms/new-console-template for more information

namespace Assignment2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Employee> employees = new List<Employee>();

            string workingDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string csvPath = Path.Combine(projectDirectory, "employees.csv");

            employees = ReadEmployeeFromCSV(csvPath);

            // LINQ Operations

            // -Group the employees by their department.

            Console.WriteLine("Grouping by Department");
            var groupByDepartment = employees.GroupBy(e => e.Department);

            foreach (var group in groupByDepartment)
            {
                Console.WriteLine($"{group.Key} Department");

                foreach (var employee in group)
                {
                    Console.WriteLine($"First Name: {employee.FirstName} Last Name: {employee.LastName} Job Title: {employee.JobTitle} Department: {employee.Department}");
                }
            }
            Console.WriteLine();

            //- Find highest salary earning Project Manager.

            Console.WriteLine("Highest salary earning Project Manager");

            var highestSalaryProjectManager = employees
                .Where(e => e.JobTitle == "Project Manager")
                .OrderByDescending(e => e.Salary)
                .FirstOrDefault();

            Console.WriteLine($"First name: {highestSalaryProjectManager.FirstName} Last Name: {highestSalaryProjectManager.LastName} Salary: {highestSalaryProjectManager.Salary}");

            Console.WriteLine();

            //  - Find the most experienced Web Developer.
            Console.WriteLine("Most experienced Web Developer");

            var mostExperienceWebDeveloper = employees
                .Where(e => e.JobTitle == "Web Developer")
                .OrderByDescending(e => e.YearsOfExperience)
                .FirstOrDefault();

            Console.WriteLine($"First name: {mostExperienceWebDeveloper.FirstName} Last Name: {mostExperienceWebDeveloper.LastName} Years of Experience: {mostExperienceWebDeveloper.YearsOfExperience}");

            Console.WriteLine();

            //- Find the average salary of all Job Title.

            Console.WriteLine("Average salary of all Job Title");

            var jobGroup = employees
                .GroupBy(e => e.JobTitle);

            foreach (var group in jobGroup)
            {
                string jobTitle = group.Key;
                float averageSalary = group.Average(e => float.Parse(e.Salary));

                Console.WriteLine($"Job Title: {jobTitle}");
                Console.WriteLine($"Average Salary: {averageSalary}");
            }

            Console.WriteLine();

            //- Find total number of male and female employees.

            Console.WriteLine("Total number of Male and Female employees");

            var totalMales = employees
                .Where(e => e.Gender == "male")
                .Count();


            var totalFemales = employees
                .Where(e => e.Gender == "female")
                .Count();

            Console.WriteLine($"Total number of males: {totalMales}");
            Console.WriteLine($"Total number of females: {totalFemales}");

            Console.WriteLine();

            Console.ReadLine();
        }

        static List<Employee> ReadEmployeeFromCSV(string csvPath)

        {
            var employees = new List<Employee>();

            Console.WriteLine("Reading employees.csv");
            if (File.Exists(csvPath))
            {
                Console.WriteLine("File found");
          
                var lines = File.ReadAllLines(csvPath).Skip(1);

                foreach (var line in lines)
                {
                    var fields = line.Split(',');

                    employees.Add(new Employee
                    {
                        FirstName = fields[0],
                        LastName = fields[1],
                        Email = fields[2],
                        Phone = fields[3],
                        Gender = fields[4],
                        Age = fields[5],
                        JobTitle = fields[6],
                        YearsOfExperience = fields[7],
                        Salary = fields[8],
                        Department = fields[9]
                    });
                }

            }
            return employees;

        }
    }
}