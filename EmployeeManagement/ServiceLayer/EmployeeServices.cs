using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.ServiceLayer
{
    public class EmployeeServices : IEmployee
    {
        private readonly AppDBContext Db;
        public EmployeeServices(AppDBContext dbContext)
        {
            Db = dbContext;
        }

        public Employee AddNewEmployee(Employee employee)
        {
            Db.employee.Add(employee);
            Db.SaveChanges();
            return employee;
        }

        public List<Employee> GetEmployeeList()
        {
            return Db.employee.ToList();
        }
    }
}
