using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP86
{
    public partial class FormConnectionSettings : Form
    {
        public FormConnectionSettings()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // ip ve port textbox'larının değerleri ipaddress ve int türüne dönüştürülebiliyorsa
                if (IPAddress.TryParse(textBoxIP.Text, out Form1.ipAddress) && int.TryParse(textBoxPort.Text, out Form1.port))
                {
                    MessageBox.Show("Bağlantı Bekleniyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("Bağlantı Sırasında Bir Sorunla Karşılaşıldı!\n\nGirdiğiniz Değerleri Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "buttonconnect");
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Name.Contains("IP") && !textBox.Text.Contains(".")) // çıkış yapılan textbox'ın adında ip varsa ve değerinde "." yoksa
                    MessageBox.Show("Geçerli Bir IP Adresi Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                else if (textBox.Name.Contains("Port")) // çıkış yapılan textbox'ın adında port
                {
                    foreach (char index in textBoxPort.Text) // textbox'ın değerleri tek tek dönülür
                    {
                        if (!char.IsDigit(index)) // eğer bir karakter sayı değilse
                        {
                            MessageBox.Show("Geçerli Bir Port Numarası Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "textboxchanged");
            }
        }
    }
}
