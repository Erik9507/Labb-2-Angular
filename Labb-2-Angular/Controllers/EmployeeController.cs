using Labb_2_Angular.Interface;
using Labb_2_Angular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Labb_2_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;   
        }

        //Get all employees
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var emp = _employeeRepository.GetEmployees.ToList();
            return Ok(emp);
        }

        //Get employee by id
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var emp = _employeeRepository.GetEmployeeById(id);
            if (emp != null)
            {
                return Ok(emp);
            }
            return null;
        }

        //Add Employee
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var emp = _employeeRepository.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = emp.EmployeeId }, emp);
        }

        //Update Employee
        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditEmployee(Employee employee, int id)
        {
            if (employee.EmployeeId != id)
            {
                return BadRequest();
            }
            var emp = _employeeRepository.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }

            _employeeRepository.UpdateEmployee(employee, id);
            return Ok(emp);      
        }

        //Delete Employee
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp = _employeeRepository.DeleteEmployee(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }


    }
}
