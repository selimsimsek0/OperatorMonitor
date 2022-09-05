using Microsoft.Extensions.DependencyInjection;
using OperatorMonitor.Business.CustomExceptions;
using OperatorMonitor.Business.Extensions;
using OperatorMonitor.Business.Helper;
using OperatorMonitor.Business.Managers;
using OperatorMonitor.Business.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorMonitor.Views
{
    public partial class OperatorMonitorForm : Form
    {
        IAccessLogManager _accesLogManager;
        public OperatorMonitorForm(IAccessLogManager accessLogManager)
        {
            InitializeComponent();
            ClearLabels();

            _accesLogManager = accessLogManager;
            GetAccesLog();
        }

        private async void GetAccesLog()
        {
            while (true)
            {
                try
                {
                    ServiceResult<AccessLogDto> logResult = await _accesLogManager.GetLog();

                    ShowLog(logResult.Data);
                }
                catch (FailedRequestDataException serviceExp)
                {
                    MessageBox.Show($"Veriler servisten getirilemedi.\n{serviceExp.Message}");
                }
                catch (VerificationFailedException verifyExp)
                {
                    FailedVerify(verifyExp.AccesLogDto);
                }
                catch (Exception exp)
                {
                    MessageBox.Show($"Erişim kaydına ulaşılamadı.\n{exp.Message}");
                }
                finally
                {
                    await Task.Delay(3000);
                }

            }
        }

        private void FailedVerify(AccessLogDto data)
        {
            using (FailedVerifyForm form = Program.ServiceProvider.GetRequiredService<FailedVerifyForm>())
            {
                form.UnsuccessVerifyLog = data;
                form.ShowDialog();
            }
        }

        private void ShowLog(AccessLogDto data)
        {
            usernameLbl.Text = data.Username;
            verifyStatusCodeLbl.Text = ((Enums.VerifyStatusCode)data.VerifyStatusCode).ToDescription();
            computerHashLbl.Text = data.ComputerHash;
            ipAddressLbl.Text = data.IPAddress;
            accessDirectionLbl.Text = ((Enums.AccessDirection)data.AccessDirection).ToDescription();
            addItionalInfoLbl.Text = data.AdditionalInfo;
            logTimeLbl.Text = data.LogTime.ToString();
            userIdLbl.Text = data.UserID;
            accessLocationLbl.Text = data.AccessLocation;
        }
        private void ClearLabels()
        {
            usernameLbl.Text = "";
            verifyStatusCodeLbl.Text = "";
            computerHashLbl.Text = "";
            ipAddressLbl.Text = "";
            accessDirectionLbl.Text = "";
            addItionalInfoLbl.Text = "";
            logTimeLbl.Text = "";
            userIdLbl.Text = "";
            accessLocationLbl.Text = "";
        }
    }
}
