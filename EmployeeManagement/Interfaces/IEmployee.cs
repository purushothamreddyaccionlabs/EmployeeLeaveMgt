using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface IEmployee
    {
        List<Employee> getEmployeeList();

        Employee AddnewEmployee(Employee employee);

      
    }
}
