using EmployeeManagement.DBLayer;

namespace EmployeeManagement.RepositoryLayer
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
