using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData qrData = qr.CreateQrCode(textBox1.Text + "\n"+textBox2.Text+"\n"+textBox3.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrData);

            Bitmap qrcodeimagen = qrcode.GetGraphic(12);
            pictureBoxQRCode.BackgroundImage = qrcodeimagen;
            

        }
       
    }
}