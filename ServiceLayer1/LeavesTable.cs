using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
