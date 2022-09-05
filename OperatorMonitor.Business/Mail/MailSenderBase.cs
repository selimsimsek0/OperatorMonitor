using OperatorMonitor.Business.Parameters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace OperatorMonitor.Business.Mail
{
    public class MailSenderBase : IMailSender
    {
        IMailSettingParametersFile _mailSettingFile;
        public MailSenderBase(IMailSettingParametersFile mailSettingFile)
        {
            _mailSettingFile = mailSettingFile;
        }
        public  void SendMail( string subject, string body = "")
        {
            try
            {
                MailMessage mailMessage = new MailMessage();

                string iniFrom = _mailSettingFile.ReadFrom();
                mailMessage.From = new MailAddress(iniFrom);

                List<string> iniToList = _mailSettingFile.ReadTo();
                foreach (string toMail in iniToList)
                {
                    mailMessage.To.Add(toMail);
                }

                mailMessage.Subject = subject;
                StringBuilder bodyBuilder = new StringBuilder();

                mailMessage.Body = body;
                SmtpClient smtp = new SmtpClient();

                smtp.Credentials = new NetworkCredential(iniFrom, _mailSettingFile.ReadFromPassword());
                smtp.Host = _mailSettingFile.ReadHost();
                smtp.EnableSsl = true;
                string iniPort = _mailSettingFile.ReadPort();
                int iniPortConvert = Convert.ToInt32(iniPort);
                smtp.Port = iniPortConvert;

                smtp.SendAsync(mailMessage, null);
            }
            catch
            {

            }
        }
    }
}
