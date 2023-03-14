using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.ServiceLayer
{
    public class LeaveReqServices:ILeaveReq
    {
        private readonly AppDBContext _Dbcontext;
        public LeaveReqServices(AppDBContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }

        public List<LeaveRequest> GetLeaveReqs()
        {
            return _Dbcontext.leaverequest.ToList();
        }

        public LeaveRequest postLeavereq(LeaveRequest request)
        {
            var employeeId = _Dbcontext.employee.Find(request.empId);
            _Dbcontext.leaverequest.Add(request);
            _Dbcontext.SaveChanges();
            return request;
        }

   /*     public object postLeavereq(ResponseStatus fianlResponse)
        {
            throw new NotImplementedException();
        }*/

        ResponseStatus ILeaveReq.RequestedLeave(int empid, LeaveRequest reqData)
        {
            //Priveleage leave
            //Wellness leave
            ResponseStatus result = new ResponseStatus(); //Creating object or instance of ResponseStatus model
        
            if (reqData.leavetype == 2 && reqData.numberofDays >= 3)
            {
                var error = "Needed medical certificate for leave approval if more than 2 days leave";
                result.errmsg = error;
                return result;
            }
            else
            {
                var noOfLeaves = reqData.numberofDays;
                var empLeaveTabledata = _Dbcontext.levesTable.Find(empid);
               if(reqData.leavetype == 1)
                {
                    var remainingPriLeaves = empLeaveTabledata.privilegeLeave;
                    if(remainingPriLeaves >= noOfLeaves)
                    {
                        empLeaveTabledata.privilegeLeave -= noOfLeaves;
                    }
                    else
                    {
                        var error = "You don't have enough leaves to apply";
                        result.errmsg = error;
                        return result;
                    }
                    
                }else if (reqData.leavetype == 2)
                {
                    var remainingWellnessLeaves = empLeaveTabledata.wellnessLeave;
                    if(remainingWellnessLeaves >= noOfLeaves)
                    {
                        empLeaveTabledata.wellnessLeave -= noOfLeaves;
                    }
                    else
                    {
                        var error = "You don't have enough wellness leaves to apply";
                        result.errmsg = error;
                        return result;
                    }
                }
            }

           return result; 
          
        }
    }
}
