// Form1.cs

using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace MotorControl
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private int currentRPM = 200;
        private byte motorID = 1; // 모터 ID, 필요시 설정

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPorts();
            timer.Start();
        }

        private void RefreshPorts()
        {
            comboBoxPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxPorts.SelectedIndex = 0;
            }
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void InitializeSerialPort(string portName, int baudRate)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            try
            {
                serialPort.Open();
                MessageBox.Show("연결 성공", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"연결 실패: {ex.Message}", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem != null && comboBoxBaudRate.SelectedItem != null)
            {
                InitializeSerialPort(comboBoxPorts.SelectedItem.ToString(), int.Parse(comboBoxBaudRate.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("Please select a COM port and Baud Rate.");
            }
        }

        private void btnClockwise_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                SendCommand(130, currentRPM); // CMD for clockwise
            }
            else
            {
                MessageBox.Show("Serial port is not connected.");
            }
        }

        private void btnCounterClockwise_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                SendCommand(130, currentRPM); // CMD for counter-clockwise
            }
            else
            {
                MessageBox.Show("Serial port is not connected.");
            }
        }

        private void btnRotateToAngle_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (int.TryParse(txtAngle.Text, out int angle))
                {
                    SendCommand(130, angle); // Example command to rotate to angle
                }
                else
                {
                    MessageBox.Show("Please enter a valid angle.");
                }
            }
            else
            {
                MessageBox.Show("Serial port is not connected.");
            }
        }

        private void btnSetRPM_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRPM.Text, out int rpm))
            {
                currentRPM = rpm;
                //SendCommand(130, currentRPM); // CMD to set RPM
                MessageBox.Show($"RPM set to {rpm}");
            }
            else
            {
                MessageBox.Show("Please enter a valid RPM.");
            }
        }

        //private void SendCommand(byte pid, int value)
        //{
        //    if (serialPort.IsOpen)
        //    {
        //        byte rmid = 183;
        //        byte tmid = 184;
        //        byte id = motorID;
        //        byte dataNumber = 1;
        //        byte[] data = BitConverter.GetBytes(value);

        //        // Compute checksum
        //        byte chk = (byte)(~(rmid + tmid + id + pid + dataNumber + data[0]) + 1);

        //        byte[] command = new byte[] { rmid, tmid, id, pid, dataNumber, data[0], chk };
        //        serialPort.Write(command, 0, command.Length);

        //        // Display sent data
        //        txtSendData.AppendText(BitConverter.ToString(command) + Environment.NewLine);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Serial port is not open.");
        //    }
        //}

        private void SendCommand(byte pid, int value)
        {
            if (serialPort.IsOpen)
            {
                //byte rmid = 183;
                //byte id = motorID;
                //byte dataNumber = 2; // 데이터를 2바이트로 전송
                //byte tmid = 184;

                // value를 2바이트로 변환
                byte[] data = BitConverter.GetBytes((short)value); // short는 2바이트 정수형이므로, value를 2바이트로 변환
                //Array.Reverse(data); // 데이터를 빅엔디안 형식으로 변환
                //11 03 01 2D 00 03 96 AE

                byte rmid = 17;
                byte tmid = 3;
                byte id = 1;
                byte pid0 = 45;
                byte dataNumber = 0;
                byte data1 = 3;
                byte data2 = 150;
                byte chk = 174;

                // 체크섬 계산
                //byte chk = (byte)(~(rmid + tmid + id + pid + dataNumber + data[0] + data[1]) + 1);

                // 명령 생성
                byte[] command = new byte[] { rmid, tmid, id, pid0, dataNumber, data1, data2, chk };
                serialPort.Write(command, 0, command.Length);

                // 전송된 데이터 표시
                txtSendData.AppendText(BitConverter.ToString(command) + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }


        //private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    if (serialPort.IsOpen)
        //    {
        //        string data = serialPort.ReadExisting();
        //        this.Invoke(new MethodInvoker(delegate { txtReceiveData.AppendText(data + Environment.NewLine); }));
        //    }
        //}

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                serialPort.Read(buffer, 0, bytesToRead);

                string hexString = BitConverter.ToString(buffer).Replace("-", " ");
                this.Invoke(new MethodInvoker(delegate { txtReceiveData.AppendText(hexString + Environment.NewLine); }));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // You can implement additional real-time monitoring logic here if needed
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSendData.Clear();
            txtReceiveData.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                SendCommand(130, 0); // CMD for clockwise
            }
            else
            {
                MessageBox.Show("Serial port is not connected.");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
