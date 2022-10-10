using Labb_2_Angular.Interface;
using Labb_2_Angular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartemnts()
        {
            var dep = _departmentRepository.GetDepartments.ToList();
            return Ok(dep);
        }

        //Add Department
        [HttpPost]
        public async Task<IActionResult> AddDepartment(Department department)
        {
            var dep = _departmentRepository.CreateDepartment(department);
            return Ok(dep);
        }

        //Delete Department
        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var dep = _departmentRepository.DeleteDepartment(id);
            if (dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }
    }
}
