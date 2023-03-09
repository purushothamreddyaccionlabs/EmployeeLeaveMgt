using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.ServiceLayer
{
    public class LeaveReqServices:ILeaveReq
    {
        private AppDBContext _Dbcontext;
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

            //if (employeeId != null)
            //{
            //    var days = request.numberofDays;

            //    if (days <= 2)
            //    {
            //        *//*  return RedirectToActionResult()*//*
            //    }
            //}
            _Dbcontext.leaverequest.Add(request);
            _Dbcontext.SaveChanges();
            return request;
          
        }
    }
}
