using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0,dogru=0,yanlis=0;

        

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            LblSoruno.Text = soruno.ToString();
            if(soruno==1)
            {
                richTextBox1.Text = "Cmhuriyet kac yilinda ilan edilmistir.";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";//Sorunun doğru cevabını atadık.

            }
            if(soruno==2)
            {
                richTextBox1.Text = "Orta Amerika'nin ulke sayisi asagidaki siklardan hangisinde dogru verilmistir.";
                BtnA.Text = "15";
                BtnB.Text = "16";
                BtnC.Text = "17";
                BtnD.Text = "18";
                label4.Text = "17";//Sorunun doğru cevabını atadık.
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Asagidakilerin hangisi Ege bölgesi sehridir";
                BtnA.Text = "İzmir";
                BtnB.Text = "Ankara";
                BtnC.Text = "İstanbul";
                BtnD.Text = "Adana";
                label4.Text = "İzmir";
                BtnSonraki.Text = "Sonuclar";//Son sorudan sonra ilerleme butonunda sonuclar yazacak.
            }
            if(soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Dogru:" + dogru + "\n" + "Yanlis:" + yanlis);
            }
        }

        

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;//A-B-C ve D şıklarına en fazla 1 defa tıklanmasını sağlar birden fazla tıklama yapılamaz.
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnA.Text;//A butonu üzerindeki cevabı label5 e aktarıyor(label 4 ile kıyas yapacaz);
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;//B şıkkındaki cevabı label5 e aktardık.(label4 ile kıyas yapıcaz);
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;//Eğer else e girerse pictureBox2 yi true yapar yani çalıştırır.
            }


        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;//Enabled etkinleştirilmiş demek ama  biz false koydugumuz için etkinleştirmiyor.
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }




    }
}
