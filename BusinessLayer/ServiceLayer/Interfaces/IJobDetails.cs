using Models;

namespace BusinessLayer.ServiceLayer.Interfaces
{
    public interface IJobDetails
    {
        List<JobDetails> GetJobDetails();

        JobDetails CreateJob(JobDetails jobdetails);
    }
}
