namespace SPR_Client
{
    partial class FormClient
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
            this.StopConecButton = new System.Windows.Forms.Button();
            this.btn_OpenConnection = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenImage = new System.Windows.Forms.Button();
            this.ResendImage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_openConnection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_sendMessage = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_openConnection.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopConecButton
            // 
            this.StopConecButton.BackColor = System.Drawing.Color.Maroon;
            this.StopConecButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StopConecButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopConecButton.ForeColor = System.Drawing.Color.White;
            this.StopConecButton.Location = new System.Drawing.Point(0, 684);
            this.StopConecButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopConecButton.Name = "StopConecButton";
            this.StopConecButton.Size = new System.Drawing.Size(407, 47);
            this.StopConecButton.TabIndex = 31;
            this.StopConecButton.Text = "قطع الاتصال";
            this.StopConecButton.UseVisualStyleBackColor = false;
            // 
            // btn_OpenConnection
            // 
            this.btn_OpenConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OpenConnection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_OpenConnection.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenConnection.Location = new System.Drawing.Point(0, 69);
            this.btn_OpenConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OpenConnection.Name = "btn_OpenConnection";
            this.btn_OpenConnection.Size = new System.Drawing.Size(407, 37);
            this.btn_OpenConnection.TabIndex = 9;
            this.btn_OpenConnection.Text = "الانظمام إلى الدردشة";
            this.btn_OpenConnection.UseVisualStyleBackColor = false;
            this.btn_OpenConnection.Click += new System.EventHandler(this.btn_OpenConnection_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(35, 25);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(116, 24);
            this.txt_IP.TabIndex = 6;
            this.txt_IP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(191, 25);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(116, 24);
            this.txt_Port.TabIndex = 7;
            this.txt_Port.Text = "5050";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 48);
            this.button1.TabIndex = 33;
            this.button1.Text = "فتح الصورة المرسلة";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_reciveMessage_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.Olive;
            this.hideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Location = new System.Drawing.Point(196, 0);
            this.hideButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(171, 55);
            this.hideButton.TabIndex = 36;
            this.hideButton.Text = "تشفير";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.BackColor = System.Drawing.Color.Olive;
            this.extractButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.extractButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.extractButton.ForeColor = System.Drawing.Color.White;
            this.extractButton.Location = new System.Drawing.Point(0, 0);
            this.extractButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(176, 55);
            this.extractButton.TabIndex = 35;
            this.extractButton.Text = "فك التشفير";
            this.extractButton.UseVisualStyleBackColor = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTextBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.Location = new System.Drawing.Point(3, 20);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataTextBox.Size = new System.Drawing.Size(367, 366);
            this.dataTextBox.TabIndex = 35;
            this.dataTextBox.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 49);
            this.button2.TabIndex = 34;
            this.button2.Text = "اختار ملف نصي";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.hideButton);
            this.panel5.Controls.Add(this.extractButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 435);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 55);
            this.panel5.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataTextBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(373, 493);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مستند نصي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Login";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 30);
            this.panel3.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBox1.Location = new System.Drawing.Point(3, 20);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(401, 361);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 30;
            this.PictureBox1.TabStop = false;
            // 
            // saveImg
            // 
            this.saveImg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveImg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveImg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.saveImg.ForeColor = System.Drawing.SystemColors.Control;
            this.saveImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveImg.Location = new System.Drawing.Point(3, 518);
            this.saveImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(401, 48);
            this.saveImg.TabIndex = 28;
            this.saveImg.Text = "احفظ الصورة بعد التعديل";
            this.saveImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveImg.UseVisualStyleBackColor = false;
            this.saveImg.Click += new System.EventHandler(this.saveImg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenImage);
            this.groupBox1.Controls.Add(this.ResendImage);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PictureBox1);
            this.groupBox1.Controls.Add(this.saveImg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(407, 569);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صورة";
            // 
            // OpenImage
            // 
            this.OpenImage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.OpenImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.OpenImage.ForeColor = System.Drawing.Color.White;
            this.OpenImage.Location = new System.Drawing.Point(3, 376);
            this.OpenImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(401, 47);
            this.OpenImage.TabIndex = 36;
            this.OpenImage.Text = "إختيار صورة";
            this.OpenImage.UseVisualStyleBackColor = false;
            this.OpenImage.Click += new System.EventHandler(this.SelectedImage_Click);
            // 
            // ResendImage
            // 
            this.ResendImage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ResendImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResendImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ResendImage.ForeColor = System.Drawing.Color.White;
            this.ResendImage.Location = new System.Drawing.Point(3, 423);
            this.ResendImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResendImage.Name = "ResendImage";
            this.ResendImage.Size = new System.Drawing.Size(401, 47);
            this.ResendImage.TabIndex = 35;
            this.ResendImage.Text = "إرسال صورة";
            this.ResendImage.UseVisualStyleBackColor = false;
            this.ResendImage.Click += new System.EventHandler(this.SendImage_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.StopConecButton);
            this.panel4.Controls.Add(this.pnl_openConnection);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(373, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 731);
            this.panel4.TabIndex = 25;
            // 
            // pnl_openConnection
            // 
            this.pnl_openConnection.Controls.Add(this.btn_OpenConnection);
            this.pnl_openConnection.Controls.Add(this.txt_IP);
            this.pnl_openConnection.Controls.Add(this.label2);
            this.pnl_openConnection.Controls.Add(this.txt_Port);
            this.pnl_openConnection.Controls.Add(this.label1);
            this.pnl_openConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_openConnection.Location = new System.Drawing.Point(0, 569);
            this.pnl_openConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_openConnection.Name = "pnl_openConnection";
            this.pnl_openConnection.Size = new System.Drawing.Size(407, 106);
            this.pnl_openConnection.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port";
            // 
            // pnl_sendMessage
            // 
            this.pnl_sendMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_sendMessage.Location = new System.Drawing.Point(0, 717);
            this.pnl_sendMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_sendMessage.Name = "pnl_sendMessage";
            this.pnl_sendMessage.Size = new System.Drawing.Size(373, 14);
            this.pnl_sendMessage.TabIndex = 19;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 523);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(373, 194);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 717);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_sendMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 731);
            this.panel1.TabIndex = 24;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 731);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormClient";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnl_openConnection.ResumeLayout(false);
            this.pnl_openConnection.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StopConecButton;
        private System.Windows.Forms.Button btn_OpenConnection;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button saveImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_openConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_sendMessage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.Button ResendImage;
    }
}

