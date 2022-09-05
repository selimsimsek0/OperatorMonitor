using System.Collections.Generic;
using System.Linq;

namespace OperatorMonitor.Business.Parameters.INI
{
    public class MailSettingFileINI : SettingFileINI, IMailSettingParametersFile
    {
        public string ReadFrom()
        {
            return ReadINI("MailSetting", "From");
        }
        public string ReadFromPassword()
        {
            return ReadINI("MailSetting", "FromPassword");
        }
        public string ReadHost()
        {
            return ReadINI("MailSetting", "Host");
        }
        public string ReadPort()
        {
            return ReadINI("MailSetting", "Port");
        }

        public void WriteDefaultValues()
        {
            WriteFrom("frommail@mail.com");
            WriteFromPassword("fromPassword");
            WriteHost("smtp.office365.com");
            WritePort("587");
            WriteTo("tomail@mail.com|tomaild@mail.com");
        }

        public List<string> ReadTo()
        {
            string toListText = ReadINI("MailSetting", "To");
            return toListText.Split("|").ToList();
        }

        public bool WriteFrom(string keyValue)
        {
            return WriteINI("MailSetting", "From", keyValue);
        }
        public bool WriteFromPassword(string keyValue)
        {
            return WriteINI("MailSetting", "FromPassword", keyValue);
        }
        public bool WriteHost(string keyValue)
        {
            return WriteINI("MailSetting", "Host", keyValue);
        }
        public bool WritePort(string keyValue)
        {
            return WriteINI("MailSetting", "Port", keyValue);
        }
        public bool WriteTo(string keyValue)
        {
            return WriteINI("MailSetting", "To", keyValue);

        }
    }
}
