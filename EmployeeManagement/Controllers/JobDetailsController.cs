using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobDetailsController : Controller
    {
        private IJobDetails _Ijobdetails;
        public JobDetailsController(IJobDetails jobdetails)
        {
            _Ijobdetails = jobdetails;
        }

        [HttpGet]
        [Route("GetJobDetails")]
        public IActionResult Get()
        {
            var result = _Ijobdetails.GetJobDetails();
            return Ok(result);
        }

        [HttpPost]
        [Route("CreateJobDetails")]
        public IActionResult Create(JobDetails jobdetails)
        {
            _Ijobdetails.CreateJob(jobdetails);
            return Created("/" + jobdetails.jobId, jobdetails);
        }
    }
}
