﻿using System;
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
        int soruno = 0, doğru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true; 

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                Lbldoğru.Text=doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lblyanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                doğru += 1;
                Lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlis += 1;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                doğru += 1;
                Lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlis += 1;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;


                label5.Text=BtnA.Text;
            if (label4.Text == label5.Text)
            {
                doğru += 1;
                Lbldoğru.Text=doğru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlis += 1;
                Lblyanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void Btnsonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled=true;
            BtnC.Enabled=true;
            BtnD.Enabled=true;
            Btnsonraki.Enabled=false;
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;

           soruno++;
            Lblsoruno.Text = soruno.ToString(); 
            if (soruno == 1) {
                richTextBox1.Text = "Cumhuriyet kaç yılın da ilan edilmiştir ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
           }
           if(soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir ege bölgemiz de bulunmaz ? ";
                BtnA.Text = "İzmir ";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
           if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                Btnsonraki.Text = "Sonuçlar";

            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                Btnsonraki.Enabled = false;
                MessageBox.Show("Doğru :" + doğru + "  Yanlış : " + yanlis);
            }
        }
    }
}
