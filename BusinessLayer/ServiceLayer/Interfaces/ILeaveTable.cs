using Models;

namespace BusinessLayer.ServiceLayer.Interfaces
{
    public interface ILeaveTable
    {
        List<LeavesTable> Getleaveinfo();

        LeavesTable GetLeavesInfoById(int id);

        LeavesTable Editdata(LeavesTable data);


    }
}
