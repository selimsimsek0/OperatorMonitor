using OperatorMonitor.Business.Models;

namespace OperatorMonitor.Business.Managers.Abstract
{
    public interface IFailedVerifyService
    {
        void OperatorResult(int second, bool verifyConfirmed, AccessLogDto unsuccessVerifyLog);
        bool CheckOperatorResult(int second, bool verifyConfirmed);
    }
}
