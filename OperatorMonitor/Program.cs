using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OperatorMonitor.Business.Mail;
using OperatorMonitor.Business.Managers;
using OperatorMonitor.Business.Managers.Abstract;
using OperatorMonitor.Business.Parameters;
using OperatorMonitor.Business.Parameters.INI;
using OperatorMonitor.Business.Providers;
using OperatorMonitor.Business.Providers.MockProviders;
using OperatorMonitor.Data.Abstract;
using OperatorMonitor.Data.Concrete.EFCore;
using OperatorMonitor.Views;
using System;
using System.IO;
using System.Windows.Forms;

namespace OperatorMonitor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Control.CheckForIllegalCrossThreadCalls = false;

            IHost host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            if(File.Exists(Application.StartupPath+"\\settings.ini")==false)
            {
                IMailSettingParametersFile mailSettingsFile = ServiceProvider.GetRequiredService<IMailSettingParametersFile>();
                mailSettingsFile.WriteDefaultValues();
            }

            Application.Run(ServiceProvider.GetRequiredService<OperatorMonitorForm>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IFailedVerifyMailSender, FailedVerifyMailSender>();
                    services.AddScoped<IOperationLogService, OperationLogManager>();
                    services.AddScoped<IOperationLogDal, EfOperationLogDal>();
                    services.AddScoped<IAccessLogManager, AccesLogManager>();
                    services.AddScoped<IMailSettingParametersFile, MailSettingFileINI>();
                    services.AddScoped<IAccessLogService, MockAccessLogService>();
                    services.AddScoped<IFailedVerifyService, FailedVerifyManager>();
                    services.AddTransient<OperatorMonitorForm>();
                    services.AddTransient<FailedVerifyForm>();
                });
        }
    }
}
