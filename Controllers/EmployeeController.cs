// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
// using EmployeeManagement.API.Data;
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
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _repository.GetById(id);
            if (employee == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(employee);
        }
       [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _repository.Add(employee);
            _repository.Save();

            return Ok(employee);
        }

        [HttpPut]
        public IActionResult Update(Employee employee)
        {
            _repository.Update(employee);
            _repository.Save();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
            return NoContent();
        }
    }
}
