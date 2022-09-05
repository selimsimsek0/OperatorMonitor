using OperatorMonitor.Business.Models;
using OperatorMonitor.Business.Parameters;
using System;

namespace OperatorMonitor.Business.Mail
{
    public class FailedVerifyMailSender : MailSenderBase, IFailedVerifyMailSender
    {
        public FailedVerifyMailSender(IMailSettingParametersFile mailSettingFile) : base(mailSettingFile)
        {

        }

        public void SendFailedVeryfAccessLogMail(AccessLogDto accessLog)
        {
            SendMail("Failed Verify " + DateTime.Now.ToString("dd.MM.yyyy"),accessLog.ToString());
        }


    }
}
