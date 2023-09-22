using MVCApplication.Data;
using MVCApplication.Models;

namespace MVCApplication.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public List <Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee? GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var newVal = _context.Employees.Find(employee.id);
            Console.WriteLine(newVal);
            if (newVal != null)
            {
                newVal.Name = employee.Name; ;
                newVal.Department = employee.Department;
                newVal.Position = employee.Position;
                newVal.Salary = employee.Salary;

                _context.Employees.Update(newVal);
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            Employee? employee = _context.Employees.Find(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }


        
    }


    
}
