using OperatorMonitor.Entity;

namespace OperatorMonitor.Business.Managers
{
    public interface IOperationLogService
    {
        bool Add(OperationLog entity);
    }
}
