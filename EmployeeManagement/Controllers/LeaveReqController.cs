using Models;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interfaces;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveReqController : Controller
    {
        #region Interfaces
        private ILeaveReq ILeavereq;
     
        #endregion

        #region constructor
        public LeaveReqController(ILeaveReq Leavereq)
        {
            ILeavereq = Leavereq;
        }
        #endregion


        [HttpGet]
        [Route("GetleavesList")]
        public IActionResult Get()
        {
            var result = ILeavereq.GetLeaveReqs();
            return Ok(result);
        }

        [HttpPost]
        [Route("RequestLeave")]
        public IActionResult RequestLeave(LeaveRequest request)
        {
            var reqdata = request;
            var fianlResponse = ILeavereq.RequestedLeave(reqdata.EmpId, reqdata);
            if(fianlResponse.Errmsg == null)
            {
                var postLeave = ILeavereq.PostLeavereq(reqdata);
                return Created("/" + postLeave.EmpId, postLeave);
            }
            else
            {
                return Ok(fianlResponse.Errmsg);
            }
         
            
        }
    }
}
