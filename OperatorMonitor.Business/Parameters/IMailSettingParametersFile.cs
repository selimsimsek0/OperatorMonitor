using System.Collections.Generic;

namespace OperatorMonitor.Business.Parameters
{
    public interface IMailSettingParametersFile : IParameterFile
    {
        void WriteDefaultValues();
        string ReadFrom();
        string ReadFromPassword();
        string ReadHost();
        string ReadPort();
        List<string> ReadTo();
        bool WriteFrom(string keyValue);
        bool WriteFromPassword(string keyValue);
        bool WriteHost(string keyValue);
        bool WritePort(string keyValue);
        bool WriteTo(string keyValue);
    }
}
