using Models;

namespace BusinessLayer.ServiceLayer.Interfaces
{
    public interface ILeaveReq
    {
        List<LeaveRequest> GetLeaveReqs();

        LeaveRequest PostLeavereq(LeaveRequest request);


        ResponseStatus RequestedLeave(int empid, LeaveRequest reqData);


    }
}
