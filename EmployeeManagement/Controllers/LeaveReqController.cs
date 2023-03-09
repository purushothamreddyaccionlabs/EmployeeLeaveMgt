using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveReqController : Controller
    {
        private ILeaveReq _ileavereq;
        private ILeaveTable _ileaveTable;
       

        public LeaveReqController(ILeaveReq ileavereq, ILeaveTable ileaveTable)
        {
            _ileavereq = ileavereq;
            _ileaveTable = ileaveTable;
        }
        [HttpGet]
        [Route("Getleavereq")]
        public IActionResult Get()
        {
            var result = _ileavereq.GetLeaveReqs();
            return Ok(result);
        }

        [HttpPost]
        [Route("reqLeave")]
        public IActionResult ReqLeave(LeaveRequest request)
        {
            if(request.leavetype == 2 && request.numberofDays >= 3)
            {
                var error = "Needed medical certificate for leave approval if more than 2 days leave";
                return Ok(error);
            }
          /*  else
            {
                var no_ofdays = request.numberofDays; //no of leaves
                var empid1 = _ileaveTable.getleavesinfobyId(request.empId);
                var leaveid1 = _ileaveTable.getleavesinfobyId(empid1.leaveId);
                var wellness1 = leaveid1.wellnessLeave - no_ofdays;
                var privielage1 = leaveid1.privilegeLeave - no_ofdays;
                if (request.leavetype == 1)
                {
                    _ileaveTable.Editdata({
                        ""
                    })
                }

            }*/
            var result = _ileavereq.postLeavereq(request);
            return Ok(result);
        }
    }
}
