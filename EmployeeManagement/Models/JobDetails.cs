using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class JobDetails
    {
        [Key]
        public int jobId { get; set; }
        [Required]
        public string designation { get; set; }
        public string department { get; set; }
        public int minsalary { get; set; }
        public int maxsalary { get; set; }

    }
}
