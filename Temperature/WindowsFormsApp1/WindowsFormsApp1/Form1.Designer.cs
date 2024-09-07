namespace MotorControl
{
    partial class Form1
    {
        // 폼에서 사용하는 GUI 컴포넌트 선언
        private System.ComponentModel.IContainer components = null; // 폼 컴포넌트 관리용 변수
        private System.Windows.Forms.Button btnClockwise; // 시계 방향 회전 버튼
        private System.Windows.Forms.Button btnCounterClockwise; // 반시계 방향 회전 버튼
        private System.Windows.Forms.Button btnRotateToAngle; // 각도 회전 버튼
        private System.Windows.Forms.TextBox txtAngle; // 각도 입력 텍스트 박스
        private System.Windows.Forms.Label lblAngle; // 각도 입력 레이블
        private System.Windows.Forms.ComboBox comboBoxPorts; // 사용 가능한 COM 포트 선택 콤보박스
        private System.Windows.Forms.Button btnRefreshPorts; // 포트 새로 고침 버튼
        private System.Windows.Forms.ComboBox comboBoxBaudRate; // 보드레이트 선택 콤보박스
        private System.Windows.Forms.Label lblBaudRate; // 보드레이트 레이블
        private System.Windows.Forms.TextBox txtRPM; // RPM 입력 텍스트 박스
        private System.Windows.Forms.Label lblRPM; // RPM 레이블
        private System.Windows.Forms.Button btnSetRPM; // RPM 설정 버튼
        private System.Windows.Forms.Button btnConnect; // 시리얼 포트 연결 버튼
        private System.Windows.Forms.TextBox txtSendData; // 전송 데이터 표시 텍스트 박스
        private System.Windows.Forms.TextBox txtReceiveData; // 수신 데이터 표시 텍스트 박스
        private System.Windows.Forms.Button btnClear; // 송수신 데이터 Clear 버튼
        private System.Windows.Forms.Button btnStop; // 모터 정지 버튼
        private System.Windows.Forms.Timer timer; // 타이머

        // Dispose 메서드: 컴포넌트 리소스를 정리하는 메서드
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // 사용한 리소스 해제
            }
            base.Dispose(disposing); // 기본 Dispose 메서드 호출
        }

        // 컴포넌트를 초기화하는 메서드
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // 컴포넌트 컨테이너 초기화
            this.btnClockwise = new System.Windows.Forms.Button(); // 시계 방향 회전 버튼 초기화
            this.btnCounterClockwise = new System.Windows.Forms.Button(); // 반시계 방향 회전 버튼 초기화
            this.btnRotateToAngle = new System.Windows.Forms.Button(); // 각도 회전 버튼 초기화
            this.txtAngle = new System.Windows.Forms.TextBox(); // 각도 입력 텍스트 박스 초기화
            this.lblAngle = new System.Windows.Forms.Label(); // 각도 레이블 초기화
            this.comboBoxPorts = new System.Windows.Forms.ComboBox(); // 포트 선택 콤보박스 초기화
            this.btnRefreshPorts = new System.Windows.Forms.Button(); // 포트 새로 고침 버튼 초기화
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox(); // 보드레이트 콤보박스 초기화
            this.lblBaudRate = new System.Windows.Forms.Label(); // 보드레이트 레이블 초기화
            this.txtRPM = new System.Windows.Forms.TextBox(); // RPM 입력 텍스트 박스 초기화
            this.lblRPM = new System.Windows.Forms.Label(); // RPM 레이블 초기화
            this.btnSetRPM = new System.Windows.Forms.Button(); // RPM 설정 버튼 초기화
            this.btnConnect = new System.Windows.Forms.Button(); // 시리얼 포트 연결 버튼 초기화
            this.txtSendData = new System.Windows.Forms.TextBox(); // 전송 데이터 표시 텍스트 박스 초기화
            this.txtReceiveData = new System.Windows.Forms.TextBox(); // 수신 데이터 표시 텍스트 박스 초기화
            this.btnClear = new System.Windows.Forms.Button(); // Clear 버튼 초기화
            this.btnStop = new System.Windows.Forms.Button(); // 모터 정지 버튼 초기화
            this.timer = new System.Windows.Forms.Timer(this.components); // 타이머 초기화
            this.SuspendLayout(); // 폼 레이아웃 시작

            // 
            // btnClockwise
            // 
            this.btnClockwise.Location = new System.Drawing.Point(12, 130); // 버튼 위치 설정
            this.btnClockwise.Name = "btnClockwise"; // 버튼 이름 설정
            this.btnClockwise.Size = new System.Drawing.Size(100, 23); // 버튼 크기 설정
            this.btnClockwise.TabIndex = 0; // 탭 인덱스 설정
            this.btnClockwise.Text = "Clockwise"; // 버튼 텍스트 설정
            this.btnClockwise.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnClockwise.Click += new System.EventHandler(this.btnClockwise_Click); // 클릭 이벤트 핸들러 연결

            // 
            // btnCounterClockwise
            // 
            this.btnCounterClockwise.Location = new System.Drawing.Point(12, 159); // 버튼 위치 설정
            this.btnCounterClockwise.Name = "btnCounterClockwise"; // 버튼 이름 설정
            this.btnCounterClockwise.Size = new System.Drawing.Size(100, 23); // 버튼 크기 설정
            this.btnCounterClockwise.TabIndex = 1; // 탭 인덱스 설정
            this.btnCounterClockwise.Text = "Counter-Clockwise"; // 버튼 텍스트 설정
            this.btnCounterClockwise.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnCounterClockwise.Click += new System.EventHandler(this.btnCounterClockwise_Click); // 클릭 이벤트 핸들러 연결

            // 
            // btnRotateToAngle
            // 
            this.btnRotateToAngle.Location = new System.Drawing.Point(12, 246); // 버튼 위치 설정
            this.btnRotateToAngle.Name = "btnRotateToAngle"; // 버튼 이름 설정
            this.btnRotateToAngle.Size = new System.Drawing.Size(100, 23); // 버튼 크기 설정
            this.btnRotateToAngle.TabIndex = 2; // 탭 인덱스 설정
            this.btnRotateToAngle.Text = "Rotate to Angle"; // 버튼 텍스트 설정
            this.btnRotateToAngle.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnRotateToAngle.Click += new System.EventHandler(this.btnRotateToAngle_Click); // 클릭 이벤트 핸들러 연결

            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(12, 220); // 텍스트 박스 위치 설정
            this.txtAngle.Name = "txtAngle"; // 텍스트 박스 이름 설정
            this.txtAngle.Size = new System.Drawing.Size(100, 20); // 텍스트 박스 크기 설정
            this.txtAngle.TabIndex = 3; // 탭 인덱스 설정

            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true; // 자동 크기 조정 활성화
            this.lblAngle.Location = new System.Drawing.Point(12, 204); // 레이블 위치 설정
            this.lblAngle.Name = "lblAngle"; // 레이블 이름 설정
            this.lblAngle.Size = new System.Drawing.Size(34, 13); // 레이블 크기 설정
            this.lblAngle.TabIndex = 4; // 탭 인덱스 설정
            this.lblAngle.Text = "Angle"; // 레이블 텍스트 설정

            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true; // 콤보박스 항목 표시 활성화
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 23); // 콤보박스 위치 설정
            this.comboBoxPorts.Name = "comboBoxPorts"; // 콤보박스 이름 설정
            this.comboBoxPorts.Size = new System.Drawing.Size(100, 21); // 콤보박스 크기 설정
            this.comboBoxPorts.TabIndex = 5; // 탭 인덱스 설정

            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(118, 21); // 버튼 위치 설정
            this.btnRefreshPorts.Name = "btnRefreshPorts"; // 버튼 이름 설정
            this.btnRefreshPorts.Size = new System.Drawing.Size(75, 23); // 버튼 크기 설정
            this.btnRefreshPorts.TabIndex = 6; // 탭 인덱스 설정
            this.btnRefreshPorts.Text = "Refresh"; // 버튼 텍스트 설정
            this.btnRefreshPorts.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click); // 클릭 이벤트 핸들러 연결

            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true; // 콤보박스 항목 표시 활성화
            this.comboBoxBaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" }); // 보드레이트 선택 항목 추가
            this.comboBoxBaudRate.Location = new System.Drawing.Point(12, 63); // 콤보박스 위치 설정
            this.comboBoxBaudRate.Name = "comboBoxBaudRate"; // 콤보박스 이름 설정
            this.comboBoxBaudRate.Size = new System.Drawing.Size(100, 21); // 콤보박스 크기 설정
            this.comboBoxBaudRate.TabIndex = 7; // 탭 인덱스 설정

            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true; // 자동 크기 조정 활성화
            this.lblBaudRate.Location = new System.Drawing.Point(12, 47); // 레이블 위치 설정
            this.lblBaudRate.Name = "lblBaudRate"; // 레이블 이름 설정
            this.lblBaudRate.Size = new System.Drawing.Size(58, 13); // 레이블 크기 설정
            this.lblBaudRate.TabIndex = 8; // 탭 인덱스 설정
            this.lblBaudRate.Text = "Baud Rate"; // 레이블 텍스트 설정

            // 
            // txtRPM
            // 
            this.txtRPM.Location = new System.Drawing.Point(12, 276); // 텍스트 박스 위치 설정
            this.txtRPM.Name = "txtRPM"; // 텍스트 박스 이름 설정
            this.txtRPM.Size = new System.Drawing.Size(100, 20); // 텍스트 박스 크기 설정
            this.txtRPM.TabIndex = 9; // 탭 인덱스 설정

            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true; // 자동 크기 조정 활성화
            this.lblRPM.Location = new System.Drawing.Point(12, 260); // 레이블 위치 설정
            this.lblRPM.Name = "lblRPM"; // 레이블 이름 설정
            this.lblRPM.Size = new System.Drawing.Size(31, 13); // 레이블 크기 설정
            this.lblRPM.TabIndex = 10; // 탭 인덱스 설정
            this.lblRPM.Text = "RPM"; // 레이블 텍스트 설정

            // 
            // btnSetRPM
            // 
            this.btnSetRPM.Location = new System.Drawing.Point(12, 302); // 버튼 위치 설정
            this.btnSetRPM.Name = "btnSetRPM"; // 버튼 이름 설정
            this.btnSetRPM.Size = new System.Drawing.Size(100, 23); // 버튼 크기 설정
            this.btnSetRPM.TabIndex = 11; // 탭 인덱스 설정
            this.btnSetRPM.Text = "Set RPM"; // 버튼 텍스트 설정
            this.btnSetRPM.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnSetRPM.Click += new System.EventHandler(this.btnSetRPM_Click); // 클릭 이벤트 핸들러 연결

            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 90); // 버튼 위치 설정
            this.btnConnect.Name = "btnConnect"; // 버튼 이름 설정
            this.btnConnect.Size = new System.Drawing.Size(100, 23); // 버튼 크기 설정
            this.btnConnect.TabIndex = 12; // 탭 인덱스 설정
            this.btnConnect.Text = "Connect"; // 버튼 텍스트 설정
            this.btnConnect.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click); // 클릭 이벤트 핸들러 연결

            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(150, 130); // 텍스트 박스 위치 설정
            this.txtSendData.Multiline = true; // 여러 줄 입력 가능
            this.txtSendData.Name = "txtSendData"; // 텍스트 박스 이름 설정
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // 스크롤바 활성화
            this.txtSendData.Size = new System.Drawing.Size(200, 100); // 텍스트 박스 크기 설정
            this.txtSendData.TabIndex = 13; // 탭 인덱스 설정

            // 
            // txtReceiveData
            // 
            this.txtReceiveData.Location = new System.Drawing.Point(150, 240); // 텍스트 박스 위치 설정
            this.txtReceiveData.Multiline = true; // 여러 줄 입력 가능
            this.txtReceiveData.Name = "txtReceiveData"; // 텍스트 박스 이름 설정
            this.txtReceiveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // 스크롤바 활성화
            this.txtReceiveData.Size = new System.Drawing.Size(200, 100); // 텍스트 박스 크기 설정
            this.txtReceiveData.TabIndex = 14; // 탭 인덱스 설정

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 350); // 버튼 위치 설정
            this.btnClear.Name = "btnClear"; // 버튼 이름 설정
            this.btnClear.Size = new System.Drawing.Size(200, 23); // 버튼 크기 설정
            this.btnClear.TabIndex = 15; // 탭 인덱스 설정
            this.btnClear.Text = "Clear"; // 버튼 텍스트 설정
            this.btnClear.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click); // 클릭 이벤트 핸들러 연결

            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 331); // 버튼 위치 설정
            this.btnStop.Name = "btnStop"; // 버튼 이름 설정
            this.btnStop.Size = new System.Drawing.Size(100, 23); // 버튼 크기 설정
            this.btnStop.TabIndex = 16; // 탭 인덱스 설정
            this.btnStop.Text = "Stop"; // 버튼 텍스트 설정
            this.btnStop.UseVisualStyleBackColor = true; // 기본 스타일 적용
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click); // 클릭 이벤트 핸들러 연결

            // 
            // timer
            // 
            this.timer.Interval = 500; // 타이머 간격 설정 (500ms)
            this.timer.Tick += new System.EventHandler(this.timer_Tick); // 타이머 틱 이벤트 핸들러 연결

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // 폼의 자동 크기 조정 설정
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // 폼 크기 조정 모드 설정
            this.ClientSize = new System.Drawing.Size(384, 391); // 폼 크기 설정
            this.Controls.Add(this.btnStop); // Stop 버튼 추가
            this.Controls.Add(this.btnClear); // Clear 버튼 추가
            this.Controls.Add(this.txtReceiveData); // 수신 데이터 텍스트 박스 추가
            this.Controls.Add(this.txtSendData); // 송신 데이터 텍스트 박스 추가
            this.Controls.Add(this.btnConnect); // 연결 버튼 추가
            this.Controls.Add(this.btnSetRPM); // RPM 설정 버튼 추가
            this.Controls.Add(this.lblRPM); // RPM 레이블 추가
            this.Controls.Add(this.txtRPM); // RPM 텍스트 박스 추가
            this.Controls.Add(this.lblBaudRate); // 보드레이트 레이블 추가
            this.Controls.Add(this.comboBoxBaudRate); // 보드레이트 콤보박스 추가
            this.Controls.Add(this.btnRefreshPorts); // 포트 새로 고침 버튼 추가
            this.Controls.Add(this.comboBoxPorts); // 포트 선택 콤보박스 추가
            this.Controls.Add(this.lblAngle); // 각도 레이블 추가
            this.Controls.Add(this.txtAngle); // 각도 텍스트 박스 추가
            this.Controls.Add(this.btnRotateToAngle); // 각도 회전 버튼 추가
            this.Controls.Add(this.btnCounterClockwise); // 반시계 방향 버튼 추가
            this.Controls.Add(this.btnClockwise); // 시계 방향 버튼 추가
            this.Name = "Form1"; // 폼 이름 설정
            this.Text = "Motor Control"; // 폼 제목 설정
            this.Load += new System.EventHandler(this.Form1_Load); // 폼 로드 이벤트 핸들러 연결
            this.ResumeLayout(false); // 폼 레이아웃 끝
            this.PerformLayout(); // 폼의 컨트롤 배치 설정
        }
    }
}
