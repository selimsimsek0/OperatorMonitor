using OperatorMonitor.Business.Models;
using System.Threading.Tasks;

namespace OperatorMonitor.Business.Providers
{
    public interface IAccessLogService
    {
        Task<ServiceResult<AccessLogDto>> GetOperationLog();
        Task<bool> ConfirmVerification(string logId);
    }
}
