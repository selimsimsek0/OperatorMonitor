using OperatorMonitor.Business.Extensions;

namespace OperatorMonitor.Business.Helper
{
    public static class Enums
    {
        /// <summary>
        /// Butun operasyonlarda dogrulama kodu olarak kullanilir.
        /// 0 Harici başarısız kabul edilir.
        /// </summary>
        public enum VerifyStatusCode
        {
            /// <summary>
            /// Başarılı
            /// </summary>
            [EnumDescription("Başarılı")]
            Success = 0,
            /// <summary>
            /// Kullanıcı bulunamadı
            /// </summary>
            [EnumDescription("Kullanıcı bulunamadı.")]
            NotFound = 1,
            /// <summary>
            /// Kullanıcının biyometrik kaydı yok
            /// </summary>
            [EnumDescription("Kullanıcının biyometrik kaydı yok.")]
            NotEnrolled = 2,
            /// <summary>
            /// Kullanıcının biyometrik tipi geçersiz
            /// </summary>
            [EnumDescription("Kullanıcının biyometrik tipi geçersiz.")]
            NotAllowedBioType = 3,
            /// <summary>
            /// Kullanıcı doğrulanamadı
            /// </summary>
            [EnumDescription("Kullanıcı doğrulanamadı.")]
            NotVerified = 4,
            /// <summary>
            /// Ziyaretçi yada Kullanıcı için Kart desteklenmiyor.
            /// </summary>
            [EnumDescription("Ziyaretçi yada Kullanıcı için Kart desteklenmiyor.")]
            CardNotSupported = 5,
        }

        /// <summary>
        /// Geçiş Yönü
        /// </summary>
        public enum AccessDirection
        {
            /// <summary>
            /// Çıkış
            /// </summary>
            [EnumDescription("Çıkış")]
            Out = 0,
            /// <summary>
            /// Giriş
            /// </summary>
            [EnumDescription("Giriş")]
            In = 1
        }
    }
}
