using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
            private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context=context;
        }
        
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
         public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }
        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }        
        }
       
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        object IEmployeeRepository.GetById(int id)
        {
            return GetById(id);
        }
    }
}