using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
