namespace OperatorMonitor.Business.Mail
{
    public interface IMailSender
    {
        void SendMail(string subject, string body = "");
    }
}
