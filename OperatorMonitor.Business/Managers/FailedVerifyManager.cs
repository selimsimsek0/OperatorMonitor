using OperatorMonitor.Business.Mail;
using OperatorMonitor.Business.Managers.Abstract;
using OperatorMonitor.Business.Models;

namespace OperatorMonitor.Business.Managers
{
    public class FailedVerifyManager : IFailedVerifyService
    {
        private IAccessLogManager _logManager;
        private IFailedVerifyMailSender _mailSender;

        public FailedVerifyManager(IAccessLogManager logManager, IFailedVerifyMailSender mailSender)
        {
            _logManager = logManager;
            _mailSender = mailSender;
        }

        public bool CheckOperatorResult(int second, bool verifyConfirmed)
        {
            return (second <= 30 && verifyConfirmed);
        }

        public  void OperatorResult(int second, bool verifyConfirmed, AccessLogDto unsuccessVerifyLog)
        {
            if (CheckOperatorResult(second, verifyConfirmed))
            {
                _logManager.ConfirmVerification(unsuccessVerifyLog);
            }
            else _mailSender.SendFailedVeryfAccessLogMail(unsuccessVerifyLog);
        }
    }
}
