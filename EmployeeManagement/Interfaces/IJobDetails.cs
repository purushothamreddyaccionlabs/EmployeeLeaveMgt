using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface IJobDetails
    {
        List<JobDetails> GetJobDetails();

        JobDetails CreateJob(JobDetails jobdetails);
    }
}
