using OperatorMonitor.Business.CustomExceptions;
using OperatorMonitor.Business.Extensions;
using OperatorMonitor.Business.Helper;
using OperatorMonitor.Business.Models;
using OperatorMonitor.Business.Providers;
using OperatorMonitor.Entity;
using System;
using System.Threading.Tasks;

namespace OperatorMonitor.Business.Managers
{
    public class AccesLogManager : IAccessLogManager
    {
        IAccessLogService _accessLogSerivce;
        IOperationLogService _operationLogManager;
        public AccesLogManager(IOperationLogService operationLogService,IAccessLogService accessLogService)
        {
            _accessLogSerivce = accessLogService;
            _operationLogManager = operationLogService;
        }


        public async Task<ServiceResult<AccessLogDto>> GetLog()
        {
            ServiceResult<AccessLogDto> serviceLogResult = await _accessLogSerivce.GetOperationLog();
            if (serviceLogResult.Response)
            {
                SaveLogToDatabase(ConvertModel.AccesLogDtoToOperationLog(serviceLogResult.Data));
            }
            else throw new FailedRequestDataException(serviceLogResult.Message);

            CheckVerifyStatusCode(serviceLogResult.Data);

            return serviceLogResult;
        }

        private void CheckVerifyStatusCode(AccessLogDto accessLog)
        {
            if (accessLog.VerifyStatusCode > 0)
                throw new VerificationFailedException(((Enums.VerifyStatusCode)accessLog.VerifyStatusCode).ToDescription(),accessLog);
        }

        private void SaveLogToDatabase(OperationLog data)
        {

            data.LogID = 0;
            bool addResult = _operationLogManager.Add(data);
            if (addResult == false) throw new Exception("Log veritabanına kaydedilemiyor.");
        }

        public async Task ConfirmVerification(AccessLogDto unsuccessVerifyLog)
        {
            await _accessLogSerivce.ConfirmVerification(unsuccessVerifyLog.LogID);
        }
    }
}
