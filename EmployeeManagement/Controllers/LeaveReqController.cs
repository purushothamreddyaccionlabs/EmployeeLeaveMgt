using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

  
    public class LeaveReqController : Controller
    {
        #region Interfaces
        private ILeaveReq _ileavereq;
        private ILeaveTable _ileaveTable;
        #endregion

        #region constructor
        public LeaveReqController(ILeaveReq ileavereq, ILeaveTable ileaveTable)
        {
            _ileavereq = ileavereq;
            _ileaveTable = ileaveTable;
        }
        #endregion


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
            else
            {
                var no_ofdays = request.numberofDays; //no of leaves
                var empid1 = _ileaveTable.getleavesinfobyId(request.empId);
                if (request.leavetype == 1)
                {
                    empid1.privilegeLeave = empid1.privilegeLeave - no_ofdays;
                    _ileaveTable.Editdata(empid1);
                }
                if(request.leavetype == 2)
                {
                    empid1.wellnessLeave = empid1.wellnessLeave - no_ofdays;
                    _ileaveTable.Editdata(empid1);
                }

            }
            var result = _ileavereq.postLeavereq(request);
            return Created("/"+result.leavereqId,result);
        }
    }
}
