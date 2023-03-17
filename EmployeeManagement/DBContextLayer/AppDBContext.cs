using Microsoft.EntityFrameworkCore;
using Models;

namespace EmployeeManagement.DBContextLayer

{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Employee> employee { get; set; }
        public DbSet<JobDetails> jobdetails { get; set; } 
        public DbSet<LeavesTable> levesTable { get; set; }
        public DbSet<LeaveRequest> leaverequest { get; set; }
        public DbSet<ResponseStatus> responseStatuses { get; set; }
    }
}
