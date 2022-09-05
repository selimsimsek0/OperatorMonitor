using System;

namespace OperatorMonitor.Entity
{
    public class OperationLog:IEntity
    {
        public long LogID { get; set; }
        /// <summary>
        /// Log'un Oluştuğu Cihaz ID
        /// </summary>
        public string ComputerHash { get; set; }
        /// <summary>
        /// Log'un oluştuğu cihaz IP
        /// </summary>
        public string IPAddress { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        /// <summary>
        /// Erişim Yapılan Yer
        /// </summary>
        public string AccessLocation { get; set; }
        /// <summary>
        /// Erişim Yönü
        /// </summary>
        public int AccessDirection { get; set; }
        /// <summary>
        /// Log Durum Kodu
        /// </summary>
        public int VerifyStatusCode { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime LogTime { get; set; }
    }

}
