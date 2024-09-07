using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace MotorControl
{
    public partial class Form1 : Form
    {
        // 시리얼 포트와 모터 관련 변수들 선언
        private SerialPort serialPort; // 시리얼 포트 객체
        private int currentRPM = 200; // 현재 RPM 값을 저장하는 변수, 기본값 200
        private byte motorID = 1; // 모터 ID, 필요시 설정 가능

        // 생성자: 폼을 초기화
        public Form1()
        {
            InitializeComponent(); // 폼 컴포넌트 초기화
        }

        // 폼이 로드될 때 호출: COM 포트 목록을 갱신하고 타이머를 시작
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPorts(); // COM 포트 목록 갱신
            timer.Start(); // 타이머 시작
        }

        // COM 포트 목록을 갱신하는 메서드
        private void RefreshPorts()
        {
            comboBoxPorts.Items.Clear(); // 기존 목록 제거
            string[] ports = SerialPort.GetPortNames(); // 사용 가능한 포트 이름 가져오기
            comboBoxPorts.Items.AddRange(ports); // 포트 이름 콤보박스에 추가
            if (ports.Length > 0)
            {
                comboBoxPorts.SelectedIndex = 0; // 첫 번째 포트를 기본으로 선택
            }
        }

        // 포트 새로 고침 버튼 클릭 시 호출
        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            RefreshPorts(); // 포트 목록 갱신
        }

        // 시리얼 포트를 초기화하는 메서드
        private void InitializeSerialPort(string portName, int baudRate)
        {
            // 기존 시리얼 포트가 열려 있으면 닫음
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            // 시리얼 포트 설정
            serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived); // 데이터 수신 이벤트 연결
            try
            {
                serialPort.Open(); // 포트 열기 시도
                MessageBox.Show("연결 성공", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information); // 성공 메시지
            }
            catch (Exception ex)
            {
                MessageBox.Show($"연결 실패: {ex.Message}", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error); // 실패 메시지
            }
        }

        // 연결 버튼 클릭 시 호출: 선택된 포트와 보드레이트로 시리얼 포트 연결
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem != null && comboBoxBaudRate.SelectedItem != null)
            {
                InitializeSerialPort(comboBoxPorts.SelectedItem.ToString(), int.Parse(comboBoxBaudRate.SelectedItem.ToString())); // 포트와 보드레이트 설정
            }
            else
            {
                MessageBox.Show("Please select a COM port and Baud Rate."); // 포트나 보드레이트가 선택되지 않은 경우 경고 메시지
            }
        }

        // 시계 방향 회전 버튼 클릭 시 호출: 시계 방향 회전 명령 전송
        private void btnClockwise_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                SendCommand(130, currentRPM); // 시계 방향 명령 전송
            }
            else
            {
                MessageBox.Show("Serial port is not connected."); // 포트가 연결되지 않은 경우 경고 메시지
            }
        }

        // 반시계 방향 회전 버튼 클릭 시 호출: 반시계 방향 회전 명령 전송
        private void btnCounterClockwise_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                SendCommand(130, currentRPM); // 반시계 방향 명령 전송
            }
            else
            {
                MessageBox.Show("Serial port is not connected."); // 포트가 연결되지 않은 경우 경고 메시지
            }
        }

        // 각도 회전 버튼 클릭 시 호출: 입력된 각도로 회전하는 명령 전송
        private void btnRotateToAngle_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (int.TryParse(txtAngle.Text, out int angle)) // 입력된 값을 각도로 변환
                {
                    SendCommand(130, angle); // 각도 회전 명령 전송
                }
                else
                {
                    MessageBox.Show("Please enter a valid angle."); // 유효한 각도가 입력되지 않은 경우 경고 메시지
                }
            }
            else
            {
                MessageBox.Show("Serial port is not connected."); // 포트가 연결되지 않은 경우 경고 메시지
            }
        }

        // RPM 설정 버튼 클릭 시 호출: 입력된 RPM 값을 설정
        private void btnSetRPM_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRPM.Text, out int rpm)) // 입력된 값을 RPM으로 변환
            {
                currentRPM = rpm; // 현재 RPM 값 설정
                MessageBox.Show($"RPM set to {rpm}"); // 설정된 RPM 값 표시
            }
            else
            {
                MessageBox.Show("Please enter a valid RPM."); // 유효한 RPM 값이 입력되지 않은 경우 경고 메시지
            }
        }

        // 명령 전송 메서드: 시리얼 포트를 통해 명령을 전송
        private void SendCommand(byte pid, int value)
        {
            if (serialPort.IsOpen) // 포트가 열려 있는지 확인
            {
                // 명령 데이터를 설정
                byte[] data = BitConverter.GetBytes((short)value); // 값을 2바이트로 변환
                byte rmid = 17; // 모듈 ID
                byte tmid = 3; // 대상 ID
                byte id = 1; // 장치 ID
                byte pid0 = 45; // 명령 PID
                byte dataNumber = 0; // 데이터 개수
                byte data1 = 3; // 데이터 값 1
                byte data2 = 150; // 데이터 값 2
                byte chk = 174; // 체크섬 값

                // 명령을 시리얼 포트로 전송
                byte[] command = new byte[] { rmid, tmid, id, pid0, dataNumber, data1, data2, chk };
                serialPort.Write(command, 0, command.Length); // 명령 전송

                // 전송된 데이터를 텍스트 박스에 표시
                txtSendData.AppendText(BitConverter.ToString(command) + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Serial port is not open."); // 포트가 열려 있지 않은 경우 경고 메시지
            }
        }

        // 데이터 수신 이벤트: 시리얼 포트에서 데이터를 수신할 때 호출
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                int bytesToRead = serialPort.BytesToRead; // 수신된 바이트 수
                byte[] buffer = new byte[bytesToRead]; // 버퍼 생성
                serialPort.Read(buffer, 0, bytesToRead); // 데이터를 버퍼에 읽음

                // 수신된 데이터를 16진수 문자열로 변환
                string hexString = BitConverter.ToString(buffer).Replace("-", " ");
                this.Invoke(new MethodInvoker(delegate { txtReceiveData.AppendText(hexString + Environment.NewLine); })); // 수신된 데이터 표시
            }
        }

        // 타이머 틱 이벤트: 실시간 모니터링 로직을 여기에 구현 가능
        private void timer_Tick(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // 실시간 모니터링 로직 구현 가능
            }
        }

        // Clear 버튼 클릭 시 호출: 송수신 텍스트 박스의 내용을 지움
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSendData.Clear(); // 송신 텍스트 박스 내용 제거
            txtReceiveData.Clear(); // 수신 텍스트 박스 내용 제거
        }

        // 정지 버튼 클릭 시 호출: 모터를 정지시키는 명령 전송
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                SendCommand(130, 0); // 모터 정지 명령 전송
            }
            else
            {
                MessageBox.Show("Serial port is not connected."); // 포트가 연결되지 않은 경우 경고 메시지
            }
        }

        // 폼이 닫힐 때 호출: 시리얼 포트가 열려 있으면 닫음
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close(); // 시리얼 포트 닫기
            }
        }
    }
}
