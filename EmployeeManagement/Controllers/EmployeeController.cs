using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;


namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployee Iemployee;
        public EmployeeController(IEmployee Employee)
        {
            Iemployee = Employee;
        }
        [HttpGet]
        [Route("GetEmployeeList")]
        public IActionResult GetEmployeeDetails()
        {
            var result = Iemployee.GetEmployeeList();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            Iemployee.AddNewEmployee(employee);
            return Created("/" + employee.EmpId, employee);
        }
    }
}
