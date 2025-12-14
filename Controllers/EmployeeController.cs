// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories.Interfaces;


namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        //dependency injection
        public  EmployeeController(IEmployeeRepository repository)
        {
            _repository=repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _repository.Add(employee);
            _repository.Save();
            return Ok(employee);
        }
    }
}
