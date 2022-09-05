using OperatorMonitor.Business.Models;
using System;

namespace OperatorMonitor.Business.CustomExceptions
{
    public class VerificationFailedException : Exception
    {
        private AccessLogDto _accesLogDto;
        public AccessLogDto AccesLogDto => _accesLogDto;
        public VerificationFailedException(string verifyStatusCodeDescripton, AccessLogDto data) : base($"Verification failed. Verification status code description:\n{verifyStatusCodeDescripton}")
        {
            _accesLogDto = data;
        }
    }
}
