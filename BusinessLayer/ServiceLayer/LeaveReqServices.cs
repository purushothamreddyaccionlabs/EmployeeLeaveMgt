using Models; 
using BusinessLayer.Interfaces;

namespace EmployeeManagement.ServiceLayer
{
    public class LeaveReqServices:ILeaveReq
    {
        private readonly AppDBContext Db;
        public LeaveReqServices(AppDBContext dbcontext)
        {
            Db = dbcontext;
        }

        public List<LeaveRequest> GetLeaveReqs()
        {
            return Db.leaverequest.ToList();
        }

        public LeaveRequest PostLeavereq(LeaveRequest request)
        {
            var employeeId = Db.employee.Find(request.EmpId);
            Db.leaverequest.Add(request);
            Db.SaveChanges();
            return request;
        }

 

        ResponseStatus ILeaveReq.RequestedLeave(int Empid, LeaveRequest reqData)
        {
            //Priveleage leave
            //Wellness leave
            ResponseStatus result = new ResponseStatus(); //Creating object or instance of ResponseStatus model
        
            if (reqData.LeaveType == 2 && reqData.NumberofDays >= 3)
            {
                var error = "Needed medical certificate for leave approval if more than 2 days leave";
                result.Errmsg = error;
                return result;
            }
            else
            {
                var noOfLeaves = reqData.NumberofDays;
                var empLeaveTabledata = Db.levesTable.Find(Empid);
               if(reqData.LeaveType == 1)
                {
                    var remainingPriLeaves = empLeaveTabledata.PrivilegeLeave;
                    if(remainingPriLeaves >= noOfLeaves)
                    {
                        empLeaveTabledata.PrivilegeLeave -= noOfLeaves;
                    }
                    else
                    {
                        var error = "You don't have enough leaves to apply";
                        result.Errmsg = error;
                        return result;
                    }
                    
                }else if (reqData.LeaveType == 2)
                {
                    var remainingWellnessLeaves = empLeaveTabledata.WellnessLeave;
                    if(remainingWellnessLeaves >= noOfLeaves)
                    {
                        empLeaveTabledata.WellnessLeave -= noOfLeaves;
                    }
                    else
                    {
                        var error = "You don't have enough wellness leaves to apply";
                        result.Errmsg = error;
                        return result;
                    }
                }
            }

           return result; 
          
        }
    }
}
