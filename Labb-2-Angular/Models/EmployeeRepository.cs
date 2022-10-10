using Labb_2_Angular.Interface;
using Microsoft.EntityFrameworkCore;

namespace Labb_2_Angular.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Employee> GetEmployees
        {
            get 
            {
                return _appDbContext.Employees.Include(d => d.Department); 
            }
        }
        public Employee GetEmployeeById(int id)
        {
            return _appDbContext.Employees.Include(d => d.Department).FirstOrDefault(e => e.EmployeeId == id);
        }

        public Employee CreateEmployee(Employee employee)
        {
            _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChangesAsync();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee, int id)
        {
            Employee empToUpdate  = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if (empToUpdate != null)
            {
                empToUpdate.FirstName = employee.FirstName;
                empToUpdate.LastName = employee.LastName;
                empToUpdate.Email = employee.Email;
                empToUpdate.PhoneNumber = employee.PhoneNumber;
                empToUpdate.Adress = employee.Adress;
                empToUpdate.Gender = employee.Gender;
                empToUpdate.Title = employee.Title;
                empToUpdate.MonthSalary = employee.MonthSalary;
                empToUpdate.Admin = employee.Admin;
                empToUpdate.DepartmentId = employee.DepartmentId;
                _appDbContext.SaveChanges();
                return empToUpdate;
            }
            return null;
        }
        public Employee DeleteEmployee(int id)
        {
            var empToDelete = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if (empToDelete != null)
            {
                _appDbContext.Employees.Remove(empToDelete);
                _appDbContext.SaveChanges();
                return empToDelete;
            }
            return null;
        }
    }
}
