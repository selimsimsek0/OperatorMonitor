using OperatorMonitor.Data.Abstract;
using OperatorMonitor.Entity;

namespace OperatorMonitor.Business.Managers
{
    public class OperationLogManager : IOperationLogService
    {
        IOperationLogDal _operationLogDal;
        public OperationLogManager(IOperationLogDal operationLogDal)
        {
            _operationLogDal = operationLogDal;
        }

        public bool Add(OperationLog entity)
        {
            return _operationLogDal.Add(entity);
        }
    }
}
