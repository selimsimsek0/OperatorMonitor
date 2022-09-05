using System;

namespace OperatorMonitor.Business.CustomExceptions
{

    public class FailedRequestDataException : Exception
    {
        public FailedRequestDataException(string serviceMessage) : base($"Failed to request data from service. Service message: {serviceMessage}")
        {

        }
    }
}
