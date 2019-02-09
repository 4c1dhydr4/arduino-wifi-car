using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Management;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using AForge.Video;
using AForge.Video.DirectShow;


namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        Thread thread;
        public delegate void ShowMessage(string message);
        public ShowMessage myDelegate;
        int port = 8242;
        UdpClient udpClient = new UdpClient(8242);
        MJPEGStream stream;
        private Joystick joystick;
        private bool[] joystickButtons;
        public MainWindow()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            joystick = new Joystick(this.Handle);
            connectToJoystick(joystick);
        }
        void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            streamPicture.Image = bmp;
        }
        private void connectToJoystick(Joystick joystick)
        {
            string sticks = joystick.FindJoysticks();
            if (sticks != null)
            {
                if (joystick.AcquireJoystick(sticks))
                {
                    enableTimer();
                    logg("Joystick Conectado");
                }
            }
        }
        private void enableTimer()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new ThreadStart(delegate ()
                {
                    joystickTimer.Enabled = true;
                }));
            }
            else
                joystickTimer.Enabled = true;
        }
        private void sendCommand(string command, Socket udpClient, IPEndPoint sendEndPoint)
        {
            Byte[] sendBytes = Encoding.ASCII.GetBytes(command.ToString());
            udpClient.SendTo(sendBytes, sendEndPoint);
            udpClient.Close();
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, port);
                byte[] content = udpClient.Receive(ref remoteIPEndPoint);
                if (content.Length >= 0)
                {
                    string message = Encoding.ASCII.GetString(content).ToString();
                    this.Invoke(myDelegate, new object[] { message });
                }
            }
        }
        private void ShowMessageMethod(string message)
        {
            try
            {
                string[] values = message.Split(':');
                int sensorValue = int.Parse(values[1]);
                if (values[0] == "M")
                {
                    pbMetano.Value = sensorValue;
                }
                if (values[0] == "S")
                {
                    pbSonido.Value = sensorValue;
                }
                if (values[0] == "T")
                {
                    pbTemperatura.Value = sensorValue;
                }
                if (values[0] == "F")
                {
                    pbFuego.Value = sensorValue;
                }
                if (values[0] == "L")
                {
                    pbLuz.Value = sensorValue;
                }
                if (values[0] == "H")
                {
                    pbHumo.Value = sensorValue;
                }
                if (values[0] == "O")
                {
                    pbObstaculos.Value = sensorValue;
                }
                if (values[0] == "P")
                {
                    pbPropano.Value = sensorValue;
                }
            }
            catch (Exception ex)
            {
                logg("Error Obteniendo datos de sensores");
                logg(ex.Message);
            }
        }

        private void logg(string input)
        {
            output.Text += input + "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDelegate = new ShowMessage(ShowMessageMethod);
            thread = new Thread(new ThreadStart(ReceiveMessage));
            thread.IsBackground = true;
            thread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var IP = IPAddress.Parse("192.168.1.177");
            int port = 8888;
            string command = "";
            var udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            var sendEndPoint = new IPEndPoint(IP, port);
            try
            {
                joystick.UpdateStatus();
                joystickButtons = joystick.buttons;
                if (joystick.Xaxis == 0)
                {
                    logg("Voltea Izquierda");
                    command = "i";
                    sendCommand(command, udpClient, sendEndPoint);
                }
                if (joystick.Xaxis == 65535)
                {
                    logg("Voltea Derecha");
                    command = "d";
                    sendCommand(command, udpClient, sendEndPoint);
                }
                if (joystick.Yaxis == 0)
                {
                    logg("Acelera");
                    command = "a";
                    sendCommand(command, udpClient, sendEndPoint);
                }
                if (joystick.Yaxis == 65535)
                {
                    logg("Retrocede");
                    command = "f";
                    sendCommand(command, udpClient, sendEndPoint);
                }
                for (int i = 0; i < joystickButtons.Length; i++)
                {
                    if (joystickButtons[i] == true)
                    {
                        output.Text += "Botón " + i + " Pulsado\n";
                        command = "b";
                        sendCommand(command, udpClient, sendEndPoint);
                    }
                }
            }
            catch
            {
                joystickTimer.Enabled = false;
                connectToJoystick(joystick);
                Console.WriteLine(e.ToString());
            }
        }

        private void clearText_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void startStream_Click(object sender, EventArgs e)
        {
            try
            {
                string ipData = tb4.Text;
                String iPadd = "http://192.168.1." + ipData + ":4747/mjpegfeed?640x480";
                stream = new MJPEGStream(iPadd);
                stream.NewFrame += stream_NewFrame;
                stream.Start();
                logg("Recibiendo Transmisión");
            }
            catch (Exception ex)
            {
                logg("Error en la Transmisión de Video\n");
                logg(ex.Message);
            }
        }

        private void stopStream_Click(object sender, EventArgs e)
        {
            stream.Stop();
            logg("Transmisión de video detenida");
        }

        private void closeThread_Click(object sender, EventArgs e)
        {
            logg("Cerrando Conexiones");
            try
            {
                thread.Abort();
                udpClient.Close();

            }
            catch (Exception ex)
            {
                output.Text = output.Text + ex.Message;
            }
        }

        private void btnEnlazarJoystick_Click(object sender, EventArgs e)
        {
            try
            {
                connectToJoystick(joystick);
            }
            catch (Exception ex)
            {

            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                thread.Abort();
                udpClient.Close();
                stream.Stop();
            }
            catch (Exception ex)
            {
                output.Text = output.Text + ex.Message;
            }
        }

        private void btnResetProgresBars_Click(object sender, EventArgs e)
        {
            pbHumo.Value = 0;
            pbFuego.Value = 0;
            pbLuz.Value = 0;
            pbMetano.Value = 0;
            pbObstaculos.Value = 0;
            pbPropano.Value = 0;
            pbSonido.Value = 0;
            pbTemperatura.Value = 0;
            logg("Medición de Sensores Reiniciada");
        }
    }
}
