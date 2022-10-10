using Labb_2_Angular.Interface;

namespace Labb_2_Angular.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Department> GetDepartments
        {
            get
            {
                return _appDbContext.Departments;
            }
        }

        public Department CreateDepartment(Department department)
        {
            _appDbContext.Departments.Add(department);
            _appDbContext.SaveChanges();     
            return department;
        }

        public Department DeleteDepartment(int id)
        {
            var DepToDelete = _appDbContext.Departments.FirstOrDefault(d => d.DepartmentId == id);
            if (DepToDelete != null)
            {
                _appDbContext.Departments.Remove(DepToDelete);
                _appDbContext.SaveChanges();
                return DepToDelete;
            }
            return null;
        }
    }
}
