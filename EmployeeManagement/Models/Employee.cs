using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        [ForeignKey("jobdetails")]
        public int jobId { get; set; }
        public Int64 contact { get; set; }
    }
}
