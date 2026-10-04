namespace ObserverPatternDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInfo = new Label();
            lblTemperature = new Label();
            trackTemperature = new TrackBar();
            chkSubscribeLog = new CheckBox();
            lstLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)trackTemperature).BeginInit();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(0, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(368, 40);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Observer: подвиньте ползунок — все подписанные \r\nнаблюдатели обновятся сами";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(0, 40);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(198, 20);
            lblTemperature.TabIndex = 1;
            lblTemperature.Text = "Текущая температура: -- °C";
            // 
            // trackTemperature
            // 
            trackTemperature.Location = new Point(0, 63);
            trackTemperature.Maximum = 40;
            trackTemperature.Minimum = -20;
            trackTemperature.Name = "trackTemperature";
            trackTemperature.Size = new Size(368, 56);
            trackTemperature.TabIndex = 2;
            trackTemperature.Value = 20;
            trackTemperature.Scroll += trackTemperature_Scroll;
            // 
            // chkSubscribeLog
            // 
            chkSubscribeLog.AutoSize = true;
            chkSubscribeLog.Checked = true;
            chkSubscribeLog.CheckState = CheckState.Checked;
            chkSubscribeLog.Location = new Point(0, 125);
            chkSubscribeLog.Name = "chkSubscribeLog";
            chkSubscribeLog.Size = new Size(266, 24);
            chkSubscribeLog.TabIndex = 3;
            chkSubscribeLog.Text = "Подписать наблюдателя журнала";
            chkSubscribeLog.UseVisualStyleBackColor = true;
            chkSubscribeLog.CheckedChanged += chkSubscribeLog_CheckedChanged;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(0, 155);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(368, 224);
            lstLog.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 404);
            Controls.Add(lstLog);
            Controls.Add(chkSubscribeLog);
            Controls.Add(trackTemperature);
            Controls.Add(lblTemperature);
            Controls.Add(lblInfo);
            Name = "Form1";
            Text = "s";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackTemperature).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label lblTemperature;
        private TrackBar trackTemperature;
        private CheckBox chkSubscribeLog;
        private ListBox lstLog;
    }
}
