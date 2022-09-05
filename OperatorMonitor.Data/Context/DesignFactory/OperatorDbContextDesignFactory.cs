using Microsoft.EntityFrameworkCore.Design;

namespace OperatorMonitor.Data.Context.DesignFactory
{
    public class OperatorDbContextDesignFactory : IDesignTimeDbContextFactory<OperatorDBContext>
    {
        public OperatorDBContext CreateDbContext(string[] args)
        {
            return new OperatorDBContext();
        }
    }
}