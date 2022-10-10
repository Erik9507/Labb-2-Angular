using Labb_2_Angular.Models;

namespace Labb_2_Angular.Interface
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments { get; }

        Department CreateDepartment(Department department);
        Department DeleteDepartment (int id);
    }
}
