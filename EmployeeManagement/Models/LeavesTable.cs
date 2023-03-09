using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class LeavesTable
    {
        [Key]
        public int leaveId { get; set; }
        public int privilegeLeave { get; set; }
        public int wellnessLeave { get; set; }
        [Required]
        public int empId { get; set; }
       
    }
}
