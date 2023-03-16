using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class ResponseStatus
    {
        [Key]
        public int Id { get; set; }
        public bool IsSuccess { get; set; }
        public Employee Data { get; set; }
        public string Errmsg { get; set; }
    }
}
