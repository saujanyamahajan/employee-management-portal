using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        //Usually placed inside an interface
        Employee GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        void Save();
    }
}