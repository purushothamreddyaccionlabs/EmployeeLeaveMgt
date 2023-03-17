using Models;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interfaces;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveTableController : Controller
    {
        private readonly ILeaveTable ILeaveTable;
        public LeaveTableController(ILeaveTable LeaveTable)
        {
            ILeaveTable = LeaveTable;
        }
        [HttpGet]
        [Route("GetleaveInfo")]
        public IActionResult Get()
        {
            var data = ILeaveTable.Getleaveinfo();
            return Ok(data);
        }
        [HttpPut]
        [Route("editdata/{id}")]
        public IActionResult Editdata(int id,LeavesTable data)
        {
            var existingdata = ILeaveTable.GetLeavesInfoById(id);
            if(existingdata != null) 
            {
                id = existingdata.LeaveId;
                ILeaveTable.Editdata(data);

            }
            return Ok(data);
        }
        
    }
}
