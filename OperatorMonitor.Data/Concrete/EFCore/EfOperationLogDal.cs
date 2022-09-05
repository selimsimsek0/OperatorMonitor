using OperatorMonitor.Data.Abstract;
using OperatorMonitor.Data.Context;
using OperatorMonitor.Entity;

namespace OperatorMonitor.Data.Concrete.EFCore
{
    public class EfOperationLogDal:EfRepositoryBase<OperationLog,OperatorDBContext>, IOperationLogDal
    {
    }
}
