using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class JobDetails
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public string Designation { get; set; }
        public string Department { get; set; }
        public int Minsalary { get; set; }
        public int Maxsalary { get; set; }

    }
}
