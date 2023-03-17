using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
