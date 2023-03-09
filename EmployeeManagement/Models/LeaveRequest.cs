using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class LeaveRequest
    {
        [Key]
        public int leavereqId { get; set; }
        [Required]
        [ForeignKey("employee")]
        public int empId { get; set; }
        [Required]
        public int leavetype { get; set; }
        [Required]
        public int numberofDays { get; set; }
        public string reason { get; set; }
    }
}
