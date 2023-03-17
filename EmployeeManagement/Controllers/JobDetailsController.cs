using Models;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interfaces;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobDetailsController : Controller
    {
        private IJobDetails Ijobdetails;
        public JobDetailsController(IJobDetails Jobdetails)
        {
            Ijobdetails = Jobdetails;
        }

        [HttpGet]
        [Route("GetJobDetails")]
        public IActionResult GetJobDetailsList()
        {
            var result = Ijobdetails.GetJobDetails();
            return Ok(result);
        }

        [HttpPost]
        [Route("CreateJobDetails")]
        public IActionResult Create(JobDetails Jobdetails)
        {
            Ijobdetails.CreateJob(Jobdetails);
            return Created("/" + Jobdetails.JobId, Jobdetails);
        }
    }
}
