using System;
using System.Text;

namespace OperatorMonitor.Business.Models
{
    public class AccessLogDto
    {
        public string LogID { get; set; }
        public string ComputerHash { get; set; }
        public string IPAddress { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string AccessLocation { get; set; }
        public int AccessDirection { get; set; }
        public int VerifyStatusCode { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime LogTime { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"LogID : {LogID}");
            builder.AppendLine($"ComputerHash : {ComputerHash}");
            builder.AppendLine($"IPAddress : {IPAddress}");
            builder.AppendLine($"UserID : {UserID}");
            builder.AppendLine($"Username : {Username}");
            builder.AppendLine($"AccessLocation : {AccessLocation}");
            builder.AppendLine($"AccessDirection : {AccessDirection}");
            builder.AppendLine($"VerifyStatusCode : {VerifyStatusCode}");
            builder.AppendLine($"AdditionalInfo : {AdditionalInfo}");
            builder.AppendLine($"LogTime : {LogTime}");

            return builder.ToString();
        }
    }
}
