using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface ILeaveTable
    {
        List<LeavesTable> Getleaveinfo();

        LeavesTable getleavesinfobyId(int id);

        LeavesTable Editdata(LeavesTable data);

        
    }
}
