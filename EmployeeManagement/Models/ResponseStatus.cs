using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class ResponseStatus
    {
        [Key]
        public int Id { get; set; }
        public bool IsSuccess { get; set; }
        public Employee data { get; set; }
        public string errmsg { get; set; }
    }
}
