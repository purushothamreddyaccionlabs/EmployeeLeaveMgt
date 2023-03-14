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
            var reqdata = request;
            var fianlResponse = _ileavereq.RequestedLeave(reqdata.empId, reqdata);
            if(fianlResponse.errmsg == null)
            {
                var postLeave = _ileavereq.postLeavereq(reqdata);
                return Created("/" + postLeave.empId, postLeave);
            }
            else
            {
                return Ok(fianlResponse.errmsg);
            }
         
            
        }
    }
}
