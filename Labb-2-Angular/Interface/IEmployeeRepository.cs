namespace Labb_2_Angular.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees { get; }

        Employee GetEmployeeById(int id);
        Employee CreateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
        Employee UpdateEmployee(Employee employee, int id);

    }
}
