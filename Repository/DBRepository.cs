using EmployeeManagement.DBContextLayer;

namespace Repository
{
    public class Repository
    {
        private readonly AppDBContext DbContext;

        public Repository(AppDBContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
