using OperatorMonitor.Business.Models;
using OperatorMonitor.Entity;

namespace OperatorMonitor.Business.Helper
{
    public static class ConvertModel
    {
        public static OperationLog AccesLogDtoToOperationLog(AccessLogDto accessLogDto)
        {
            long convertedId;
            if (long.TryParse(accessLogDto.LogID, out long logId))
            {
                convertedId = logId;
            }
            else throw new System.Exception("Conversion failed");

            return new OperationLog
            {
                LogID = convertedId,
                VerifyStatusCode = accessLogDto.VerifyStatusCode,
                AccessDirection = accessLogDto.AccessDirection,
                AccessLocation = accessLogDto.AccessLocation,
                AdditionalInfo = accessLogDto.AdditionalInfo,
                ComputerHash = accessLogDto.ComputerHash,
                IPAddress = accessLogDto.IPAddress,
                Username = accessLogDto.Username,
                LogTime = accessLogDto.LogTime,
                UserID = accessLogDto.UserID,
            };
        }
    }
}
