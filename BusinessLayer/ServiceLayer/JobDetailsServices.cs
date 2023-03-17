using BusinessLayer.Interfaces;
using Models; 

namespace EmployeeManagement.ServiceLayer
{
    public class JobDetailsServices:IJobDetails
    {
        private readonly AppDBContext Db;
        public JobDetailsServices(AppDBContext dbcontext)
        {
            Db = dbcontext;
        }

        public JobDetails CreateJob(JobDetails jobdetails)
        {
            Db.jobdetails.Add(jobdetails);
            Db.SaveChanges();
            return jobdetails;
        }

        public List<JobDetails> GetJobDetails()
        {
            return Db.jobdetails.ToList();
        }
    }
}
