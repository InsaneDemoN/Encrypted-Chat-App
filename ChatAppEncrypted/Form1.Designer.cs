namespace ChatAppEncrypted
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Settings_panel = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Clientlabel = new System.Windows.Forms.Label();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.Serverlabel = new System.Windows.Forms.Label();
            this.Server_port_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Server_ip_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings_button = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Msg_textBox = new System.Windows.Forms.TextBox();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Chat_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Send_textBox = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.StatusStripConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.EncKeytextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptionComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AutoDecryptCheckBox = new System.Windows.Forms.CheckBox();
            this.Key_textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EncKeytextBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Settings_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_button)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings_panel
            // 
            this.Settings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Settings_panel.Controls.Add(this.Backbutton);
            this.Settings_panel.Controls.Add(this.label3);
            this.Settings_panel.Controls.Add(this.label4);
            this.Settings_panel.Controls.Add(this.Clientlabel);
            this.Settings_panel.Controls.Add(this.Connectbutton);
            this.Settings_panel.Controls.Add(this.Startbutton);
            this.Settings_panel.Controls.Add(this.ClientPorttextBox);
            this.Settings_panel.Controls.Add(this.ClientIPtextBox);
            this.Settings_panel.Controls.Add(this.Serverlabel);
            this.Settings_panel.Controls.Add(this.Server_port_textBox);
            this.Settings_panel.Controls.Add(this.label2);
            this.Settings_panel.Controls.Add(this.Server_ip_textBox);
            this.Settings_panel.Controls.Add(this.label1);
            this.Settings_panel.Location = new System.Drawing.Point(0, 49);
            this.Settings_panel.Name = "Settings_panel";
            this.Settings_panel.Size = new System.Drawing.Size(1019, 596);
            this.Settings_panel.TabIndex = 0;
            this.Settings_panel.Visible = false;
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(892, 521);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 47);
            this.Backbutton.TabIndex = 28;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "IP";
            // 
            // Clientlabel
            // 
            this.Clientlabel.AutoSize = true;
            this.Clientlabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientlabel.Location = new System.Drawing.Point(469, 358);
            this.Clientlabel.Name = "Clientlabel";
            this.Clientlabel.Size = new System.Drawing.Size(84, 31);
            this.Clientlabel.TabIndex = 25;
            this.Clientlabel.Text = "Client";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connectbutton.Location = new System.Drawing.Point(461, 493);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(108, 36);
            this.Connectbutton.TabIndex = 24;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbutton.Location = new System.Drawing.Point(461, 235);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(108, 36);
            this.Startbutton.TabIndex = 23;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPorttextBox.Location = new System.Drawing.Point(589, 435);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(318, 27);
            this.ClientPorttextBox.TabIndex = 22;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIPtextBox.Location = new System.Drawing.Point(173, 435);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(318, 27);
            this.ClientIPtextBox.TabIndex = 20;
            // 
            // Serverlabel
            // 
            this.Serverlabel.AutoSize = true;
            this.Serverlabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serverlabel.Location = new System.Drawing.Point(469, 87);
            this.Serverlabel.Name = "Serverlabel";
            this.Serverlabel.Size = new System.Drawing.Size(90, 31);
            this.Serverlabel.TabIndex = 18;
            this.Serverlabel.Text = "Server";
            // 
            // Server_port_textBox
            // 
            this.Server_port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_port_textBox.Location = new System.Drawing.Point(589, 183);
            this.Server_port_textBox.Name = "Server_port_textBox";
            this.Server_port_textBox.Size = new System.Drawing.Size(318, 27);
            this.Server_port_textBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "PORT";
            // 
            // Server_ip_textBox
            // 
            this.Server_ip_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_ip_textBox.Location = new System.Drawing.Point(173, 183);
            this.Server_ip_textBox.Name = "Server_ip_textBox";
            this.Server_ip_textBox.Size = new System.Drawing.Size(318, 27);
            this.Server_ip_textBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP";
            // 
            // Settings_button
            // 
            this.Settings_button.Image = global::ChatAppEncrypted.Properties.Resources.icons8_settings_80;
            this.Settings_button.Location = new System.Drawing.Point(866, 1);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(50, 50);
            this.Settings_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings_button.TabIndex = 1;
            this.Settings_button.TabStop = false;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Message";
            // 
            // Msg_textBox
            // 
            this.Msg_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg_textBox.Location = new System.Drawing.Point(244, 160);
            this.Msg_textBox.Name = "Msg_textBox";
            this.Msg_textBox.Size = new System.Drawing.Size(618, 27);
            this.Msg_textBox.TabIndex = 4;
            // 
            // Key_textBox
            // 
            this.Key_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key_textBox.Location = new System.Drawing.Point(244, 204);
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(247, 27);
            this.Key_textBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Key";
            // 
            // Chat_textBox
            // 
            this.Chat_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chat_textBox.Location = new System.Drawing.Point(244, 319);
            this.Chat_textBox.Multiline = true;
            this.Chat_textBox.Name = "Chat_textBox";
            this.Chat_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat_textBox.Size = new System.Drawing.Size(618, 177);
            this.Chat_textBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chat";
            // 
            // Send_textBox
            // 
            this.Send_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_textBox.Location = new System.Drawing.Point(141, 526);
            this.Send_textBox.Name = "Send_textBox";
            this.Send_textBox.Size = new System.Drawing.Size(618, 27);
            this.Send_textBox.TabIndex = 10;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(788, 543);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(108, 41);
            this.Sendbutton.TabIndex = 11;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // StatusStripConnection
            // 
            this.StatusStripConnection.ActiveLinkColor = System.Drawing.Color.Black;
            this.StatusStripConnection.BackColor = System.Drawing.Color.Transparent;
            this.StatusStripConnection.Name = "StatusStripConnection";
            this.StatusStripConnection.Size = new System.Drawing.Size(239, 20);
            this.StatusStripConnection.Text = "Connection Status : Not Connected";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // EncKeytextBox
            // 
            this.EncKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncKeytextBox.Location = new System.Drawing.Point(141, 578);
            this.EncKeytextBox.Name = "EncKeytextBox";
            this.EncKeytextBox.Size = new System.Drawing.Size(265, 27);
            this.EncKeytextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Message";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(483, 253);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(108, 41);
            this.DecryptButton.TabIndex = 15;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptionComboBox
            // 
            this.EncryptionComboBox.FormattingEnabled = true;
            this.EncryptionComboBox.Items.AddRange(new object[] {
            "SHA 256",
            "Triple DES",
            "3DES + SHA 256"});
            this.EncryptionComboBox.Location = new System.Drawing.Point(244, 79);
            this.EncryptionComboBox.Name = "EncryptionComboBox";
            this.EncryptionComboBox.Size = new System.Drawing.Size(247, 24);
            this.EncryptionComboBox.TabIndex = 16;
            this.EncryptionComboBox.SelectedIndexChanged += new System.EventHandler(this.EncryptionComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Encryption Protocol";
            // 
            // AutoDecryptCheckBox
            // 
            this.AutoDecryptCheckBox.AutoSize = true;
            this.AutoDecryptCheckBox.Location = new System.Drawing.Point(630, 264);
            this.AutoDecryptCheckBox.Name = "AutoDecryptCheckBox";
            this.AutoDecryptCheckBox.Size = new System.Drawing.Size(112, 21);
            this.AutoDecryptCheckBox.TabIndex = 18;
            this.AutoDecryptCheckBox.Text = "Auto Decrypt";
            this.AutoDecryptCheckBox.UseVisualStyleBackColor = true;
            this.AutoDecryptCheckBox.CheckedChanged += new System.EventHandler(this.AutoDecryptCheckBox_CheckedChanged);
            // 
            // Key_textBox2
            // 
            this.Key_textBox2.Enabled = false;
            this.Key_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key_textBox2.Location = new System.Drawing.Point(617, 204);
            this.Key_textBox2.Name = "Key_textBox2";
            this.Key_textBox2.Size = new System.Drawing.Size(247, 27);
            this.Key_textBox2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(554, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Key 2";
            // 
            // EncKeytextBox2
            // 
            this.EncKeytextBox2.Enabled = false;
            this.EncKeytextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncKeytextBox2.Location = new System.Drawing.Point(512, 578);
            this.EncKeytextBox2.Name = "EncKeytextBox2";
            this.EncKeytextBox2.Size = new System.Drawing.Size(247, 27);
            this.EncKeytextBox2.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(454, 578);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Key 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.Settings_panel);
            this.Controls.Add(this.EncKeytextBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Key_textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AutoDecryptCheckBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EncryptionComboBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EncKeytextBox);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Send_textBox);
            this.Controls.Add(this.Chat_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Key_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Msg_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Settings_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat App";
            this.Settings_panel.ResumeLayout(false);
            this.Settings_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_button)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Settings_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Clientlabel;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.Label Serverlabel;
        private System.Windows.Forms.TextBox Server_port_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Server_ip_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Settings_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Msg_textBox;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Chat_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Send_textBox;
        private System.Windows.Forms.Button Sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripConnection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox EncKeytextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.ComboBox EncryptionComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AutoDecryptCheckBox;
        private System.Windows.Forms.TextBox Key_textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EncKeytextBox2;
        private System.Windows.Forms.Label label12;
    }
}

