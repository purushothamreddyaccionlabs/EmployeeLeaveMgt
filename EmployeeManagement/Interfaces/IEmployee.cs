using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetEmployeeList();

        Employee AddNewEmployee(Employee employee);

      
    }
}
