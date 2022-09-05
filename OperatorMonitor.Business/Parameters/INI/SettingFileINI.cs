using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OperatorMonitor.Business.Parameters.INI
{
    public class SettingFileINI
    {
        private static string FilePath => AppDomain.CurrentDomain.BaseDirectory + "\\settings.ini";

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        protected bool WriteINI(string SectionName, string KeyName, string StringToWrite)
        {
            bool Return;
            Return = WritePrivateProfileString(SectionName, KeyName, StringToWrite, FilePath);
            return Return;
        }

        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        protected string ReadINI(string lpAppName, string lpKeyName)
        {
            StringBuilder sb = new StringBuilder(5000);
            GetPrivateProfileString(lpAppName, lpKeyName, "", sb, sb.Capacity, FilePath);
            string alinan = sb.ToString();
            sb.Clear();
            return alinan;
        }
    }
}
