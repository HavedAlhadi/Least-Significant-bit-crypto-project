using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
////////////////////////////
using MyNetwork;

namespace SPR_Client
{
    public partial class FormClient : Form
    {
        Thread Th1;
        string ip = "10.0.0.1";
        int port = 5050;
        public FormClient()
        {
            InitializeComponent();
            Th1 = new Thread(Accept);
        }
        Net socket = new Net();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        void Accept()
        {
            btn_reciveMessage_Click(null, null);
        }
     
        IWebCam webCam = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = webCam.iWebCam_Image;
            if (img != null)
            {
                PictureBox1.Image = img;
                socket.sendImg(img);
            }
        }

        private void SelectedImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = Image.FromFile(ofd.FileName);
            }
         
        }

        private void btn_OpenConnection_Click(object sender, EventArgs e)
        {
            try
            { 
            socket.createClient(txt_IP.Text, Convert.ToInt32(txt_Port.Text));
            richTextBox1.Text += ": Client>>تم الاتصال بالسيرفر\n";
            }
            catch { richTextBox1.Text += ": Client>>خطاء في الاتصال بالسرفر... \n"; }
        }

        private void SendImage_Click(object sender, EventArgs e)
        {
            socket.sendImg(PictureBox1.Image);
                //MessageBox.Show("تم ارسال الصوة");
        }
        public void received_img(Image img)
        {
            this.Invoke((Action)(() =>
            {
                PictureBox1.Image = img;
                PictureBox1.Refresh();
            }));
            socket.receiveImg(this, received_img);
        }
        private void btn_reciveMessage_Click(object sender, EventArgs e)
        {
            socket.receiveImg(this, received_img);
        }
        //++++++++++++++++++++++++++++++++++++++++
        enum State
        {
            hiding,
            filling_with_zeros
        };
        Bitmap bmp = null;
        string extractedText = string.Empty;
        public static Bitmap embedText(string text, Bitmap bmp)
        {
            State s = State.hiding;

            int charIndex = 0;
            int charValue = 0;
            long colorUnitIndex = 0;
            int zeros = 0;

            int R = 0, G = 0, B = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    pixel = Color.FromArgb(pixel.R - pixel.R % 2,
                        pixel.G - pixel.G % 2, pixel.B - pixel.B % 2);
                    R = pixel.R; G = pixel.G; B = pixel.B;
                    for (int n = 0; n < 3; n++)
                    {
                        if (colorUnitIndex % 8 == 0)
                        {
                            if (zeros == 8)
                            {
                                if ((colorUnitIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                return bmp;
                            }

                            if (charIndex >= text.Length)
                            {
                                s = State.filling_with_zeros;
                            }
                            else
                            {
                                charValue = text[charIndex++];
                            }
                        }

                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    if (s == State.hiding)
                                    {
                                        R += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (s == State.hiding)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (s == State.hiding)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        colorUnitIndex++;

                        if (s == State.filling_with_zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }
        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }

        public static string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = reverseBits(charValue);

                            if (charValue == 0)
                            {
                                return extractedText;
                            }

                            char c = (char)charValue;

                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }
        //زر التشفير
        private void hideButton_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                bmp = (Bitmap)PictureBox1.Image;

                string text = dataTextBox.Text;

                if (text.Equals(""))
                {
                    MessageBox.Show("The text you want to hide can't be empty", "Wrong!");

                    return;
                }
                bmp = embedText(text, bmp);
                MessageBox.Show("Your text was hidden in the image successfully!", "Done");
                dataTextBox.Text = "";
            }
        }
        //فك التشفير
        private void extractButton_Click(object sender, EventArgs e)
        {
            dataTextBox.Text = "";
            bmp = (Bitmap)PictureBox1.Image;
            string extractedText = extractText(bmp);
            if (extractedText.Contains(" "))
                dataTextBox.Text = extractedText;
            else
            {
                dataTextBox.Text = "لا يوجد نص مشفر";
            }
        }

        private void saveImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }
                MessageBox.Show("تم الحفظ بنجاح... ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataTextBox.Text = File.ReadAllText(ofd.FileName);
            }
        }
    }
}
