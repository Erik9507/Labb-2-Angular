using Microsoft.EntityFrameworkCore;

namespace Labb_2_Angular.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Erik",
                LastName = "Norell",
                Email = "erik@norell.com",
                PhoneNumber = "0701232343",
                Gender = "Male",
                Adress = "Kungsgatan 1",
                Title = "Developer",
                MonthSalary = 50000,
                Admin = false,
                DepartmentId = 2,
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Lukas",
                LastName = "Rose",
                Email = "lukas@rose.com",
                PhoneNumber = "0709878761",
                Gender = "Male",
                Adress = "Sveagatan 3",
                Title = "Sales Manager",
                MonthSalary = 45000,
                Admin = false,
                DepartmentId = 1,
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Tobias",
                LastName = "Landen",
                Email = "tobias@landen.com",
                PhoneNumber = "0705362188",
                Gender = "Male",
                Adress = "Drottninggatan 4",
                Title = "Team Leader",
                MonthSalary = 60000,
                Admin = true,
                DepartmentId = 2,
            });

            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 1,
                DepartmentName = "Sale"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 2,
                DepartmentName = "Development"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 3,
                DepartmentName = "Hr"
            });
        }


    }
}
