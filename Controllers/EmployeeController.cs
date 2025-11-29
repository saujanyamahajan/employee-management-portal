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

    }
}
