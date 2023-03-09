using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.ServiceLayer
{
    public class EmployeeServices : IEmployee
    {
        private AppDBContext _dbContext;
        public EmployeeServices(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Employee AddnewEmployee(Employee employee)
        {
            _dbContext.employee.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public List<Employee> getEmployeeList()
        {
            return _dbContext.employee.ToList();
        }
    }
}
