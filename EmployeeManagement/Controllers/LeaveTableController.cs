using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveTableController : Controller
    {
        private readonly ILeaveTable _ileaveTable;
        public LeaveTableController(ILeaveTable ileaveTable)
        {
            _ileaveTable = ileaveTable;
        }
        [HttpGet]
        [Route("GetleaveInfo")]
        public IActionResult Get()
        {
            var data = _ileaveTable.Getleaveinfo();
            return Ok(data);
        }
        [HttpPut]
        [Route("editdata/{id}")]
        public IActionResult editdata(int id,LeavesTable data)
        {
            var existingdata = _ileaveTable.getleavesinfobyId(id);
            if(existingdata != null) 
            {
                id = existingdata.leaveId;
                _ileaveTable.Editdata(data);

            }
            return Ok(data);
        }
      /*  [HttpGet]
        [Route("getItem/{id}")]
        public IActionResult GetindivisualItems(int id)
        {
            var data = _ileaveTable.getexatvalue(id);
            return Ok(data);
        }*/
    }
}
