using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
            [Key]
            public int EmpId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }

            [ForeignKey("jobdetails")]
            public int JobId { get; set; }
            public Int64 Contact { get; set; }
        
    }
}