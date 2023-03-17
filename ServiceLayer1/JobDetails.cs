using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
