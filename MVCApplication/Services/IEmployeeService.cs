using MVCApplication.Models;

namespace MVCApplication.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee? GetEmployee(int id);

        void CreateEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int id);
    }
}
