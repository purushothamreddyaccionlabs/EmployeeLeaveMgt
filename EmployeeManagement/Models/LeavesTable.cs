using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class LeavesTable
    {
        #region Fields
        [Key]
        public int LeaveId { get; set; }
        public int PrivilegeLeave { get; set; }
        public int WellnessLeave { get; set; }
        [Required]
        public int EmpId { get; set; }
        #endregion
    }
}
