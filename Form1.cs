using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP86
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static IPAddress ipAddress = null;
        public static int port = 0;
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        TcpListener server = null;
        TcpClient client;
        NetworkStream stream;

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormConnectionSettings connectionSettings = new FormConnectionSettings();
                connectionSettings.ShowDialog();
                if (ipAddress != null && port != 0)
                {
                    Text = "ESP8266 - Bağlantı Bekleniyor...";
                    splitContainer1.Enabled = true;
                    buttonCloseConnection.Enabled = true;
                    buttonReceiveData.Enabled = true;
                    buttonStartLoop.Enabled = true;
                    connectionToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "ConnectionToolStrip");
            }
        }

        private async Task ReceiveData(IPAddress ip, int port)
        {
            await Task.Run(() =>
            {
                try
                {
                    server = new TcpListener(ip, port);
                    server.Start();

                    Byte[] bytes = new Byte[256];
                    String data = null;
                    client = server.AcceptTcpClient();
                    Text = "ESP8266 - Bağlantı Kuruldu.";

                    while (true)
                    {
                        data = null;
                        stream = client.GetStream();
                        int bytesRead;

                        while ((bytesRead = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRead);
                            if (dataGridView1.Rows.Count > 12)
                                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                            dataGridView1.Rows.Insert(0, DateTime.Now, data, "-");
                            if (data.Contains("s"))
                            {
                                data = data.Substring(0, data.IndexOf("s")) + " °C";
                                textBoxTemperature.Text = data;
                            }
                            else if (data.Contains("n"))
                            {
                                data = data.Substring(0, data.IndexOf("n")) + " BPM";
                                textBoxHeartBeat.Text = data;
                            }
                            else if (data.Contains("l"))
                            {
                                data = data.Substring(0, data.IndexOf("l"));
                                textBoxLoadCell.Text = data;
                            }
                        }
                    }
                }
                catch (SocketException)
                {
                    MessageBox.Show("Bağlantı Kapatıldı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    server.Stop();
                }
            });
        }

        private void buttonCloseConnection_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (server != null)
                    server.Stop();
                if (client != null)
                {
                    client.Close();
                    client.Dispose();
                }
                client = null;
                server = null;
                stream = null;
                buttonCloseConnection.Enabled = false;
                buttonStartLoop.Enabled = false;
                buttonReceiveData.Enabled = false;
                connectionToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "CloseConnection");
            }
        }

        private async void buttonReceiveData_Click(object sender, EventArgs e)
        {
            try
            {
                buttonReceiveData.Enabled = false;
                buttonCloseConnection.Enabled = true;
                await ReceiveData(ipAddress, port);
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Kapatıldı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonStartLoop_Click(object sender, EventArgs e)
        {
            try
            {
                stream = client.GetStream();
                Byte[] data = System.Text.Encoding.ASCII.GetBytes("a");
                stream.Write(data, 0, data.Length);
                if (dataGridView1.Rows.Count > 12)
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                dataGridView1.Rows.Insert(0, DateTime.Now, "-", "a");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "CloseConnection");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAbout about = new FormAbout();  
                about.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "About");
            }
        }
    }
}
