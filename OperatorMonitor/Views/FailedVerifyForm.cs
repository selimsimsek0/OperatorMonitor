using OperatorMonitor.Business.Extensions;
using OperatorMonitor.Business.Helper;
using OperatorMonitor.Business.Managers.Abstract;
using OperatorMonitor.Business.Models;
using System;
using System.Windows.Forms;

namespace OperatorMonitor.Views
{
    public partial class FailedVerifyForm : Form
    {
        private Timer _timer;
        private bool _verifyConfirmed = false;
      
        private IFailedVerifyService _failedVerifyService;

        private AccessLogDto _unsuccessVerifyLog;
        public AccessLogDto UnsuccessVerifyLog
        {
            get => _unsuccessVerifyLog;
            set
            {
                _unsuccessVerifyLog = value;
                LoadView(UnsuccessVerifyLog);
            }

        }
        public FailedVerifyForm(IFailedVerifyService failedVerifyService)
        {
            InitializeComponent();

            _failedVerifyService = failedVerifyService;

            _timer = new Timer
            {
                Interval = 1000
            };

            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void LoadView(AccessLogDto accessLogDto)
        {
            accessDirectionLbl.Text = ((Enums.AccessDirection)accessLogDto.AccessDirection).ToDescription();
            accessLocationLbl.Text = accessLogDto.AccessLocation;
            computerHashLbl.Text = accessLogDto.ComputerHash;
            ipAddressLbl.Text = accessLogDto.IPAddress;
            logTimeLbl.Text = accessLogDto.LogTime.ToString("dd/MM/yyyy HH:mm.ss");
            usernameLbl.Text = accessLogDto.Username;
            verifyStatusCodeLbl.Text = ((Enums.VerifyStatusCode)accessLogDto.VerifyStatusCode).ToDescription();
            userIdLbl.Text = accessLogDto.UserID;
            additionalInfoLbl.Text = accessLogDto.AdditionalInfo;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            timerProgresBar.PerformStep();
            if (timerProgresBar.Value > 30) this.Close();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmVerifyBtn_Click(object sender, EventArgs e)
        {
            _verifyConfirmed = true;
            this.Close();
        }

        private void FailedVerifyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _failedVerifyService.OperatorResult(second: timerProgresBar.Value, verifyConfirmed: _verifyConfirmed, unsuccessVerifyLog: UnsuccessVerifyLog);
        }
    }
}
