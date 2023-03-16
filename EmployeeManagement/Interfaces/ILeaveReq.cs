using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface ILeaveReq
    {
        List<LeaveRequest> GetLeaveReqs();

        LeaveRequest PostLeavereq(LeaveRequest request);
   

        ResponseStatus RequestedLeave(int empid, LeaveRequest reqData);

       
    }
}
