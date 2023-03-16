using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface ILeaveTable
    {
        List<LeavesTable> Getleaveinfo();

        LeavesTable GetLeavesInfoById(int id);

        LeavesTable Editdata(LeavesTable data);

        
    }
}
