using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            SURElabel2.Text = sure.ToString();

            if (sure == 15)
            {
                timer1.Enabled = false;
                sorubtn.Enabled = false;
                kontrolbtn.Enabled =false;
                baslabtn.Enabled = false;
            }
        }

        private void baslabtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void tekrarbtn_Click(object sender, EventArgs e)
        {
            sorubtn.Enabled = true;
            kontrolbtn.Enabled = true;
            baslabtn.Enabled = true;
        }
        Random x = new Random();
        int sayi1, sayi2, cevap, sonuc, puan;

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*int islem;
            islem = x.Next(1,5);

            switch (islem)
            {
                case 1: labelisaret1.Text = "+"; sonuc = sayi1 + sayi2;break;
                case 2: labelisaret1.Text = "-"; sonuc = sayi1 - sayi2; break;
                case 3: labelisaret1.Text = "*"; sonuc = sayi1 * sayi2; break;
                case 4: labelisaret1.Text = "/"; sonuc = sayi1 / sayi2; break;
                default:
                    break; 
            }*/
        }

        private void SURElabel2_Click(object sender, EventArgs e)
        {

        }

        private void sorubtn_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            sayi1 = x.Next(1, 10);
            sayi2 = x.Next(1,10);
            SAYI1textBox.Text = sayi1.ToString();
            SAYI2textBox.Text = sayi2.ToString();
            sonuc = sayi1 + sayi2;

            int islem;
            islem = x.Next(1, 5);

            switch (islem)
            {
                case 1: labelisaret1.Text = "+"; sonuc = sayi1 + sayi2; break;
                case 2: labelisaret1.Text = "-"; sonuc = sayi1 - sayi2; break;
                case 3: labelisaret1.Text = "*"; sonuc = sayi1 * sayi2; break;
                case 4: labelisaret1.Text = "/"; sonuc = sayi1 / sayi2; break;
                default:
                    break;
            }
        }

        private void KONTROL_Click(object sender, EventArgs e)
        {
            cevap = Int32.Parse(txtcevap.Text);
            if(sonuc == cevap )
            {
                puan += 10;
            }
            else
            {
                puan -= 5;
            }
            PUANlabel1.Text = puan.ToString();
        }


        private void sayı3_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
