using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.ServiceLayer
{
    public class LeaveTableServices:ILeaveTable
    {
        private AppDBContext _Dbcontext;
        public LeaveTableServices(AppDBContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }

        public LeavesTable Editdata(LeavesTable data)
        {
            var existingdata = _Dbcontext.levesTable.Find(data.leaveId);
            if (existingdata != null) 
            {
                existingdata.leaveId = data.leaveId;
                existingdata.privilegeLeave = data.privilegeLeave;
                existingdata.wellnessLeave = data.wellnessLeave;
                existingdata.empId = data.empId;
            }
            _Dbcontext.levesTable.Update(existingdata);
            _Dbcontext.Entry(existingdata).Property(x => x.leaveId).IsModified = false;//To prevent Identity column update issue
            _Dbcontext.SaveChanges();
            return data;
        }

        public List<LeavesTable> Getleaveinfo()
        {
            return _Dbcontext.levesTable.ToList();
        }

        public LeavesTable getleavesinfobyId(int id)
        {
            var task = _Dbcontext.levesTable.Find(id);
            return task;
        }
    }
}
