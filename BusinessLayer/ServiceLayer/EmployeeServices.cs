using EmployeeManagement.DBContextLayer;
using Models;

namespace BusinessLayer.ServiceLayer
{
    public class EmployeeServices
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