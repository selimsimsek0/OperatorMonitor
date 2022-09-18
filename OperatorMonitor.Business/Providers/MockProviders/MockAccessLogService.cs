using OperatorMonitor.Business.Models;
using System;
using System.Threading.Tasks;

namespace OperatorMonitor.Business.Providers.MockProviders
{
    public class MockAccessLogService : IAccessLogService
    {
        public Task<bool> ConfirmVerification(string logId)
        {
            Task<bool> asyncPost = Task.FromResult(true);
            return asyncPost;
        }

        public Task<ServiceResult<AccessLogDto>> GetOperationLog()
        {
            Random randomStatusCode = new Random();
            Task<ServiceResult<AccessLogDto>> asyncGet = Task.FromResult(new ServiceResult<AccessLogDto>
            {
                Response = true,
                Message="OK",
                Data= new AccessLogDto
                {
                    AccessDirection=1,
                    AccessLocation= "AccessLocation",
                    AdditionalInfo= "AdditionalInfo",
                    ComputerHash= "ComputerHash",
                    IPAddress= "IPAddress",
                    LogID= "1",
                    LogTime=DateTime.Now,
                    UserID= "UserID",
                    Username= "Username",
                    VerifyStatusCode=randomStatusCode.Next(0,5)
                   // VerifyStatusCode=0
                }
            });

            return asyncGet;
        }
    }
}
