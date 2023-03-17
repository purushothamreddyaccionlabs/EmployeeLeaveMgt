using Models;

namespace BusinessLayer.ServiceLayer.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetEmployeeList();

        Employee AddNewEmployee(Employee employee);


    }
}
