using System;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatAppEncrypted.Resources;

namespace ChatAppEncrypted
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve,cipher;
        public String TextToSend, EncTextToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in ip)
            {
                Server_ip_textBox.Text = address.ToString();
            }
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            if (Settings_panel.Visible)
            {
                Settings_panel.Hide();
            }
            else
            {
                Settings_panel.Show();
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(Server_port_textBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream())
            {
                AutoFlush = true
            };

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientPorttextBox.Text));

            try
            {
                client.Connect(IpEnd);

                if (client.Connected)
                {
                    Chat_textBox.AppendText("Connected to server" + "\n");
                    Chat_textBox.AppendText(Environment.NewLine);
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                
                StatusStripConnection.Text = "Connection Status : Connected";
                statusStrip1.BackColor = Color.LightGreen;

                cipher = STR.ReadLine();
                Msg_textBox.Text = cipher;
                if (AutoDecryptCheckBox.Checked)
                {
                    try
                    {
                        recieve = Decryption(Key_textBox.Text, cipher,Key_textBox2.Text);
                        if (!String.IsNullOrWhiteSpace(recieve))
                        {
                            this.Chat_textBox.Invoke(new MethodInvoker(delegate ()
                            {
                                Chat_textBox.AppendText("Sender:" + recieve + "\n");
                                Chat_textBox.AppendText(Environment.NewLine);
                            }));
                            recieve = "";
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }

            }
            if (!client.Connected)
            {
                StatusStripConnection.Text = "Connection Status : Not Connected";

                statusStrip1.BackColor = Color.Red;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.Chat_textBox.Invoke(new MethodInvoker(delegate ()
                {
                    Chat_textBox.AppendText("Me:" + TextToSend + "\n");
                    Chat_textBox.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }


        private void DecryptButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                recieve = Decryption(Key_textBox.Text, Msg_textBox.Text,Key_textBox2.Text);
                if (!String.IsNullOrWhiteSpace(recieve))
                {
                    this.Chat_textBox.Invoke(new MethodInvoker(delegate ()
                    {
                        Chat_textBox.AppendText("Sender:" + recieve + "\n");
                        Chat_textBox.AppendText(Environment.NewLine);
                    }));
                    recieve = "";
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AutoDecryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoDecryptCheckBox.Checked)
            {
                EncryptionComboBox.Enabled = false;
                Msg_textBox.Enabled = false;
                Key_textBox.Enabled = false;
                Key_textBox2.Enabled = false;
            }
            else
            {
                EncryptionComboBox.Enabled = true;
                Msg_textBox.Enabled = true;
                Key_textBox.Enabled = true;
                if (EncryptionComboBox.Text.Equals("3DES + SHA 256")){
                    Key_textBox2.Enabled = true;
                }
            }
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Send_textBox.Text))
            {
                EncTextToSend = Send_textBox.Text;
                switch (EncryptionComboBox.Text)
                {
                   case "SHA 256": TextToSend = SHA256Crypt.Encrypt(EncTextToSend, EncKeytextBox.Text);
                        backgroundWorker2.RunWorkerAsync();
                        break;
                    case "Triple DES": TextToSend = TripleDESCrypt.EncryptString(EncKeytextBox.Text, EncTextToSend);
                        backgroundWorker2.RunWorkerAsync();
                        break;
                    case "3DES + SHA 256": string TripleEncryption = TripleDESCrypt.EncryptString(EncKeytextBox.Text, EncTextToSend);
                        TextToSend = SHA256Crypt.Encrypt(TripleEncryption, EncKeytextBox2.Text);
                        backgroundWorker2.RunWorkerAsync();
                        break;
                    default: MessageBox.Show("No protocol Selected!");
                        break;
                }
                
            }
            Send_textBox.Clear();
        }

        private void EncryptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(EncryptionComboBox.Text.Equals("3DES + SHA 256"))
            {
                Key_textBox2.Enabled = true;
                EncKeytextBox2.Enabled = true;
                label6.Text = label8.Text = "Key 1";
                
            }
            else
            {
                Key_textBox2.Enabled = false;
                EncKeytextBox2.Enabled = false;
                label6.Text = label8.Text = "Key";
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Settings_panel.Hide();
        }
        private string Decryption(string key,string text,string key2=null)
        {
            string recieve;
            switch (EncryptionComboBox.Text)
            {
                case "SHA 256":
                    recieve = SHA256Crypt.Decrypt(text, key);
                    break;
                case "Triple DES":
                    recieve = TripleDESCrypt.DecryptString(key, text);
                    break;
                case "3DES + SHA 256": string ShaDecryption = SHA256Crypt.Decrypt(text, key2);
                    recieve = TripleDESCrypt.DecryptString(key, ShaDecryption);
                    break;
                default:
                    MessageBox.Show("No protocol Selected!");
                    recieve = null;
                    break;
            }
            return recieve;
        }
    }
}
