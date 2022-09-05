using OperatorMonitor.Business.Models;

namespace OperatorMonitor.Business.Mail
{
    public interface IFailedVerifyMailSender : IMailSender
    {
        void SendFailedVeryfAccessLogMail(AccessLogDto accessLog);
    }
}
