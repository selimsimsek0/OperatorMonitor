
namespace OperatorMonitor.Views
{
    partial class FailedVerifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerProgresBar = new System.Windows.Forms.ProgressBar();
            this.closeBtn = new System.Windows.Forms.Button();
            this.confirmVerifyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.verifyStatusCodeLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.accessLocationLbl = new System.Windows.Forms.Label();
            this.accessDirectionLbl = new System.Windows.Forms.Label();
            this.logTimeLbl = new System.Windows.Forms.Label();
            this.computerHashLbl = new System.Windows.Forms.Label();
            this.ipAddressLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.additionalInfoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerProgresBar
            // 
            this.timerProgresBar.Location = new System.Drawing.Point(12, 440);
            this.timerProgresBar.Maximum = 31;
            this.timerProgresBar.Name = "timerProgresBar";
            this.timerProgresBar.Size = new System.Drawing.Size(495, 29);
            this.timerProgresBar.Step = 1;
            this.timerProgresBar.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Maroon;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(361, 380);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(146, 54);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Kapat";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // confirmVerifyBtn
            // 
            this.confirmVerifyBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.confirmVerifyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmVerifyBtn.ForeColor = System.Drawing.Color.White;
            this.confirmVerifyBtn.Location = new System.Drawing.Point(12, 380);
            this.confirmVerifyBtn.Name = "confirmVerifyBtn";
            this.confirmVerifyBtn.Size = new System.Drawing.Size(146, 54);
            this.confirmVerifyBtn.TabIndex = 1;
            this.confirmVerifyBtn.Text = "Geçişi Onayla";
            this.confirmVerifyBtn.UseVisualStyleBackColor = false;
            this.confirmVerifyBtn.Click += new System.EventHandler(this.confirmVerifyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başarısız Geçiş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lokasyon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durum Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kullanıcı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yön: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Zaman: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cihaz ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cihaz IP:";
            // 
            // verifyStatusCodeLbl
            // 
            this.verifyStatusCodeLbl.AutoSize = true;
            this.verifyStatusCodeLbl.Location = new System.Drawing.Point(108, 57);
            this.verifyStatusCodeLbl.Name = "verifyStatusCodeLbl";
            this.verifyStatusCodeLbl.Size = new System.Drawing.Size(50, 20);
            this.verifyStatusCodeLbl.TabIndex = 3;
            this.verifyStatusCodeLbl.Text = "label9";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(108, 87);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(50, 20);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "label9";
            // 
            // accessLocationLbl
            // 
            this.accessLocationLbl.AutoSize = true;
            this.accessLocationLbl.Location = new System.Drawing.Point(108, 149);
            this.accessLocationLbl.Name = "accessLocationLbl";
            this.accessLocationLbl.Size = new System.Drawing.Size(50, 20);
            this.accessLocationLbl.TabIndex = 3;
            this.accessLocationLbl.Text = "label9";
            // 
            // accessDirectionLbl
            // 
            this.accessDirectionLbl.AutoSize = true;
            this.accessDirectionLbl.Location = new System.Drawing.Point(108, 180);
            this.accessDirectionLbl.Name = "accessDirectionLbl";
            this.accessDirectionLbl.Size = new System.Drawing.Size(50, 20);
            this.accessDirectionLbl.TabIndex = 3;
            this.accessDirectionLbl.Text = "label9";
            // 
            // logTimeLbl
            // 
            this.logTimeLbl.AutoSize = true;
            this.logTimeLbl.Location = new System.Drawing.Point(108, 211);
            this.logTimeLbl.Name = "logTimeLbl";
            this.logTimeLbl.Size = new System.Drawing.Size(50, 20);
            this.logTimeLbl.TabIndex = 3;
            this.logTimeLbl.Text = "label9";
            // 
            // computerHashLbl
            // 
            this.computerHashLbl.AutoSize = true;
            this.computerHashLbl.Location = new System.Drawing.Point(108, 274);
            this.computerHashLbl.Name = "computerHashLbl";
            this.computerHashLbl.Size = new System.Drawing.Size(50, 20);
            this.computerHashLbl.TabIndex = 3;
            this.computerHashLbl.Text = "label9";
            // 
            // ipAddressLbl
            // 
            this.ipAddressLbl.AutoSize = true;
            this.ipAddressLbl.Location = new System.Drawing.Point(108, 304);
            this.ipAddressLbl.Name = "ipAddressLbl";
            this.ipAddressLbl.Size = new System.Drawing.Size(50, 20);
            this.ipAddressLbl.TabIndex = 3;
            this.ipAddressLbl.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kullanıcı ID:";
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Location = new System.Drawing.Point(108, 118);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(50, 20);
            this.userIdLbl.TabIndex = 3;
            this.userIdLbl.Text = "label9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ek Bilgi:";
            // 
            // additionalInfoLbl
            // 
            this.additionalInfoLbl.AutoSize = true;
            this.additionalInfoLbl.Location = new System.Drawing.Point(106, 243);
            this.additionalInfoLbl.Name = "additionalInfoLbl";
            this.additionalInfoLbl.Size = new System.Drawing.Size(50, 20);
            this.additionalInfoLbl.TabIndex = 3;
            this.additionalInfoLbl.Text = "label9";
            // 
            // FailedVerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 485);
            this.Controls.Add(this.ipAddressLbl);
            this.Controls.Add(this.computerHashLbl);
            this.Controls.Add(this.additionalInfoLbl);
            this.Controls.Add(this.logTimeLbl);
            this.Controls.Add(this.accessDirectionLbl);
            this.Controls.Add(this.accessLocationLbl);
            this.Controls.Add(this.userIdLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.verifyStatusCodeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmVerifyBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.timerProgresBar);
            this.Name = "FailedVerifyForm";
            this.Text = "FailedVerifyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FailedVerifyForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar timerProgresBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button confirmVerifyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label verifyStatusCodeLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label accessLocationLbl;
        private System.Windows.Forms.Label accessDirectionLbl;
        private System.Windows.Forms.Label logTimeLbl;
        private System.Windows.Forms.Label computerHashLbl;
        private System.Windows.Forms.Label ipAddressLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label additionalInfoLbl;
    }
}