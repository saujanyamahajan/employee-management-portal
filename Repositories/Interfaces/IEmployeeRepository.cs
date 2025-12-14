using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        //Usually placed inside an interface
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        void Save();
        object GetById(int id);
    }
}