using OperatorMonitor.Business.Models;
using System.Threading.Tasks;

namespace OperatorMonitor.Business.Managers
{
    public interface IAccessLogManager
    {
        Task<ServiceResult<AccessLogDto>> GetLog();
        Task ConfirmVerification(AccessLogDto unsuccessVerifyLog);
    }
}
