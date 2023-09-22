using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.Services;
// using MVCApplication.Data;

namespace MVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employeeService.GetEmployees();

            return View(employees);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            _employeeService.CreateEmployee(employee);

            return RedirectToAction("Index", "Employee"); ;

        }

        public IActionResult Edit(int index)
        {
            var employee = _employeeService.GetEmployee(index);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            if (!ModelState.IsValid)
			{
                return View(model);
            }

            _employeeService.UpdateEmployee(model);

            return RedirectToAction("Index", "Employee");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _employeeService.DeleteEmployee(id);

            return RedirectToAction("Index");
        }

    }
}
