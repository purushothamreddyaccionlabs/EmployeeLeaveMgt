using EmployeeManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployee _Iemployee;
        public EmployeeController(IEmployee Emp)
        {
            _Iemployee = Emp;
        }
        [HttpGet]
        [Route("GetEmployeeList")]
        public IActionResult Getemp()
        {
            var result = _Iemployee.getEmployeeList();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _Iemployee.AddnewEmployee(employee);
            return Created("/" + employee.empId, employee);
        }
    }
}
