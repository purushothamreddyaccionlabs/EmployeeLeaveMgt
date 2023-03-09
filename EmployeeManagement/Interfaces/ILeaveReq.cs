using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface ILeaveReq
    {
        List<LeaveRequest> GetLeaveReqs();

        LeaveRequest postLeavereq(LeaveRequest request);

       
    }
}
