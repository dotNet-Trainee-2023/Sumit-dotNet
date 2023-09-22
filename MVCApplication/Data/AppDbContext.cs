using Microsoft.EntityFrameworkCore;
using MVCApplication.Models;

namespace MVCApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(new List<Employee>
            {
                new Employee
                {
                    id = 1,
                    Name = "Ram",
                    Department = "Web Development",
                    Position = "Front-end Developer",
                    Salary = 30000
                },
                new Employee
                {
                    id = 2,
                    Name = "Sudarshan",
                    Department = "HR",
                    Position = "Manager",
                    Salary = 40000
                },

                new Employee
                {
                    id = 3,
                    Name = "Manoj",
                    Department = "Web Development",
                    Position = "Back-end Developer",
                    Salary = 35000
                }

            });
        }
    }
}
