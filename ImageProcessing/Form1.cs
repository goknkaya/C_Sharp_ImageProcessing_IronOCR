using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr; //IronOCR' de görüntü işleme yapabilmek için IronOCR kütüphanesini ekledik.

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image; //OpenFileDialog' ta açılacak resmi image değişkenine alacağız.
        string text;

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Eğer açılan OpenFileDialog penceresinde OK' a tıklanmışsa
            {
                image = new Bitmap(file.FileName); //Yolu belirtilen resmi Bitmap sınıfı olarak türet ve image değişkenine aktar.
                pbFile.Image = image; //Oluşturduğumuz image değişkenini Formumuzda bulunan PictureBox' a attık.
            }
        }

        private void btnConvertFile_Click(object sender, EventArgs e)
        {
            var ocr = new AutoOcr(); //Görüntü işlemek için kullanacağımız ocr değişkeni tanımlandı.
            text=ocr.Read(image).ToString(); //ocr değişkenimiz resmimizi okudu ve görüntü işleyerek text değişkenimize aktardık.
            rbFile.Text = text; //RichTextBox' a text değişkenimizi attık. En nihayetinde görüntü işlendi.
        }
    }
}
