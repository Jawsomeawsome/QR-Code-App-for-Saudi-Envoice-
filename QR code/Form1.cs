using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using IronBarCode;
using System;
using System.Drawing;
using System.Linq;
using QRCoder;

namespace QR_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static String text2hex(Int32 Tagnum, String TagVal)
        {
            string hexval = text2hex(TagVal);
            string hextag = decToHexa(Tagnum);
            string hexlen = decToHexa(TagVal.Length);
            return (hextag + hexlen + hexval);
        }

        public static string Base64StringEncode(string originalString)
        {
            //var bytes = Encoding.UTF8.GetBytes(originalString);
            //var encodedString = Convert.ToBase64String(bytes);
            //return encodedString;

            byte[] byt = System.Text.Encoding.UTF8.GetBytes(originalString);
            // convert the byte array to a Base64 string
            return Convert.ToBase64String(byt);
        }

        public static string HexToBase64(string strInput)
        {
          
                var bytes = new byte[strInput.Length / 2];
                for (var i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
                }
                return Convert.ToBase64String(bytes);

           
        }


        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);


        }

        public static String text2hex(string Val)
        {
            string decString = Val;
            byte[] bytes = Encoding.Default.GetBytes(decString);
            string hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        public static String decToHexa(int n)
        {
            int i = n;
            string hex = i.ToString("X");
            if (hex.Length < 2)
            {
                hex = "0" + hex;
            }
            return hex;


        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string outputHex = Convert.ToString(int.Parse("1"), 16);
            //Console.WriteLine(outputHex);

            string hexval = text2hex("RICC");
            string tagval = decToHexa(15);

            string CompName = txtCompanyName.Text;
            string Vatno = txtVatNo.Text;
            string datetimetax = txtTimeDate.Text;
            string amountTotal = txtAmount.Text;
            string amountVat = txtVat.Text;


        
            Console.WriteLine("Hexcode");
            string Hexcode = text2hex(1, CompName) + text2hex(2, Vatno) + text2hex(3, datetimetax) + text2hex(4, amountTotal) + text2hex(5, amountVat);
                     
            txtBase64.Text=(HexToBase64(Hexcode));

            string HextoBase = Base64StringEncode(Hexcode);


            //QRCodeWriter.CreateQrCode(txtBase64.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng("MyQR.png");

            // pictureBox1.ImageLocation = @"C:\Users\hussain.firzan\source\repos\QR code\QR code\bin\Debug\MyQR.png";


            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtBase64.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;

            //pictureBox1.Image = QRCodeWriter.CreateQrCode(txtBase64.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).Image;
            pictureBox1.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

           





        }

        private void btnLoadSample_Click(object sender, EventArgs e)
        {
           txtCompanyName.Text= "Riyadh International Catering Corporation Limited";
           txtVatNo.Text= "30023467640003";
           txtTimeDate.Text= "2022-04-25 15:30:00";
           txtAmount.Text="200.00";
           txtVat.Text="30.00";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtVatNo.Text = "";
            txtTimeDate.Text = "";
            txtAmount.Text = "";
            txtVat.Text = "";

            txtBase64.Text = "";
            pictureBox1.ImageLocation ="";

            pictureBox1.Visible = false;

        }
    }

        
      
    
}
