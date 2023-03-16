using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class LeaveRequest
    {
        [Key]
        public int LeavereqId { get; set; }
        [Required]
        [ForeignKey("employee")]
        public int EmpId { get; set; }
        [Required]
        public int LeaveType { get; set; }
        [Required]
        public int NumberofDays { get; set; }
        public string Reason { get; set; }
    }
}
