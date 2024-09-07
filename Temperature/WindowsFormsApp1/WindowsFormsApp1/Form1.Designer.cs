namespace MotorControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClockwise;
        private System.Windows.Forms.Button btnCounterClockwise;
        private System.Windows.Forms.Button btnRotateToAngle;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.TextBox txtRPM;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Button btnSetRPM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.TextBox txtReceiveData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop; // Stop 버튼 추가
        private System.Windows.Forms.Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClockwise = new System.Windows.Forms.Button();
            this.btnCounterClockwise = new System.Windows.Forms.Button();
            this.btnRotateToAngle = new System.Windows.Forms.Button();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.lblRPM = new System.Windows.Forms.Label();
            this.btnSetRPM = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.txtReceiveData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button(); // Stop 버튼 초기화
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClockwise
            // 
            this.btnClockwise.Location = new System.Drawing.Point(12, 130);
            this.btnClockwise.Name = "btnClockwise";
            this.btnClockwise.Size = new System.Drawing.Size(100, 23);
            this.btnClockwise.TabIndex = 0;
            this.btnClockwise.Text = "Clockwise";
            this.btnClockwise.UseVisualStyleBackColor = true;
            this.btnClockwise.Click += new System.EventHandler(this.btnClockwise_Click);
            // 
            // btnCounterClockwise
            // 
            this.btnCounterClockwise.Location = new System.Drawing.Point(12, 159);
            this.btnCounterClockwise.Name = "btnCounterClockwise";
            this.btnCounterClockwise.Size = new System.Drawing.Size(100, 23);
            this.btnCounterClockwise.TabIndex = 1;
            this.btnCounterClockwise.Text = "Counter-Clockwise";
            this.btnCounterClockwise.UseVisualStyleBackColor = true;
            this.btnCounterClockwise.Click += new System.EventHandler(this.btnCounterClockwise_Click);
            // 
            // btnRotateToAngle
            // 
            this.btnRotateToAngle.Location = new System.Drawing.Point(12, 246);
            this.btnRotateToAngle.Name = "btnRotateToAngle";
            this.btnRotateToAngle.Size = new System.Drawing.Size(100, 23);
            this.btnRotateToAngle.TabIndex = 2;
            this.btnRotateToAngle.Text = "Rotate to Angle";
            this.btnRotateToAngle.UseVisualStyleBackColor = true;
            this.btnRotateToAngle.Click += new System.EventHandler(this.btnRotateToAngle_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(12, 220);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 3;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(12, 204);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(34, 13);
            this.lblAngle.TabIndex = 4;
            this.lblAngle.Text = "Angle";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 23);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPorts.TabIndex = 5;
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(118, 21);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPorts.TabIndex = 6;
            this.btnRefreshPorts.Text = "Refresh";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(12, 63);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBaudRate.TabIndex = 7;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(12, 47);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRate.TabIndex = 8;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // txtRPM
            // 
            this.txtRPM.Location = new System.Drawing.Point(12, 276);
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.Size = new System.Drawing.Size(100, 20);
            this.txtRPM.TabIndex = 9;
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(12, 260);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(31, 13);
            this.lblRPM.TabIndex = 10;
            this.lblRPM.Text = "RPM";
            // 
            // btnSetRPM
            // 
            this.btnSetRPM.Location = new System.Drawing.Point(12, 302);
            this.btnSetRPM.Name = "btnSetRPM";
            this.btnSetRPM.Size = new System.Drawing.Size(100, 23);
            this.btnSetRPM.TabIndex = 11;
            this.btnSetRPM.Text = "Set RPM";
            this.btnSetRPM.UseVisualStyleBackColor = true;
            this.btnSetRPM.Click += new System.EventHandler(this.btnSetRPM_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 90);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(150, 130);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendData.Size = new System.Drawing.Size(200, 100);
            this.txtSendData.TabIndex = 13;
            // 
            // txtReceiveData
            // 
            this.txtReceiveData.Location = new System.Drawing.Point(150, 240);
            this.txtReceiveData.Multiline = true;
            this.txtReceiveData.Name = "txtReceiveData";
            this.txtReceiveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceiveData.Size = new System.Drawing.Size(200, 100);
            this.txtReceiveData.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 331);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            //
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReceiveData);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSetRPM);
            this.Controls.Add(this.lblRPM);
            this.Controls.Add(this.txtRPM);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.btnRefreshPorts);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.btnRotateToAngle);
            this.Controls.Add(this.btnCounterClockwise);
            this.Controls.Add(this.btnClockwise);
            this.Name = "Form1";
            this.Text = "Motor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
