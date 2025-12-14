using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
         IEnumerable<Employee> GetAll(); //Returns a collection of Employee objects (read-only operation)
         //Usually placed inside an interface
        Employee GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        void Save();
    }
}