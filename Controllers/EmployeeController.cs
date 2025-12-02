using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;


 namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        //dependency injection
        public  EmployeeController(AppDbContext context)
        {
            _context=context;
        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            return Ok(_context.Employees.ToList());
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(employee);
        }
    }
}
