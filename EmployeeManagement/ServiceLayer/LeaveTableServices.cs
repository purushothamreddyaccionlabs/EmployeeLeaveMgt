using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.ServiceLayer
{
    public class LeaveTableServices:ILeaveTable
    {
        private  readonly AppDBContext Db;
        public LeaveTableServices(AppDBContext dbcontext)
        {
            Db = dbcontext;
        }

        public LeavesTable Editdata(LeavesTable data)
        {
            var existingdata = Db.levesTable.Find(data.LeaveId);
            if (existingdata != null) 
            {
                existingdata.LeaveId = data.LeaveId;
                existingdata.PrivilegeLeave = data.PrivilegeLeave;
                existingdata.WellnessLeave = data.WellnessLeave;
                existingdata.EmpId = data.EmpId;
            }
            Db.levesTable.Update(existingdata);
            Db.Entry(existingdata).Property(x => x.LeaveId).IsModified = false;//To prevent Identity column update issue
            Db.SaveChanges();
            return data;
        }

        public List<LeavesTable> Getleaveinfo()
        {
            return Db.levesTable.ToList();
        }

        public LeavesTable GetLeavesInfoById(int id)
        {
            var task = Db.levesTable.Find(id);
            return task;
        }
    }
}
