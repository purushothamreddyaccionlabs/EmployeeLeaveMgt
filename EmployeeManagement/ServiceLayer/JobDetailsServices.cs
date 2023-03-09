using EmployeeManagement.DBLayer;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.ServiceLayer
{
    public class JobDetailsServices:IJobDetails
    {
        private AppDBContext _dbcontext;
        public JobDetailsServices(AppDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public JobDetails CreateJob(JobDetails jobdetails)
        {
            _dbcontext.jobdetails.Add(jobdetails);
            _dbcontext.SaveChanges();
            return jobdetails;
        }

        public List<JobDetails> GetJobDetails()
        {
            return _dbcontext.jobdetails.ToList();
        }
    }
}
