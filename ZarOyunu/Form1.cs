using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int oyun;
        int bilgPara = 120;
        int sayac;
        int totalZarBir;
        int zarToplam;
        int totalZarIki;
        int oyucuPara = 10;
        int total;
        int zarNumara;
        Image[] ResimDizi = new Image[6];
        Random rnd = new Random();

        public void KucukKontrol() 
        {
            if (totalZarBir > totalZarIki)
            {
                if (oyun == 5)
                {
                    lblKasa.Text = (total / 2).ToString();
                    total = total / 2;
                }
                bilgPara += total;               
                lblBilgPara.Text = bilgPara.ToString();
                lblOyuncuPara.Text = oyucuPara.ToString();
            }
            else if (totalZarBir < totalZarIki)
            {
                if (oyun == 5)
                {
                    lblKasa.Text = (total / 2).ToString();
                    total = total / 2;
                }
                oyucuPara += total;
                lblBilgPara.Text = bilgPara.ToString();
                lblOyuncuPara.Text = oyucuPara.ToString();
            }
            else if (totalZarBir == totalZarIki)
            {
                if (oyun == 5)
                {
                    lblKasa.Text = (total / 2).ToString();
                    total = total / 2;
                }
                oyucuPara += total / 2;
                bilgPara += total / 2;
                lblBilgPara.Text = bilgPara.ToString();
                lblOyuncuPara.Text = oyucuPara.ToString();
            }
        }
        public void BuyukKontrol() 
        {
            if (totalZarBir > totalZarIki)
            {
                if (oyun == 5)
                {
                    lblKasa.Text = (total / 2).ToString();
                    total = total / 2;
                }
                oyucuPara += total;
                lblBilgPara.Text = bilgPara.ToString();
                lblOyuncuPara.Text = oyucuPara.ToString();
            }
            else if (totalZarBir < totalZarIki)
            {
                if (oyun == 5)
                {
                    lblKasa.Text = (total / 2).ToString();
                    total = total / 2;
                }
                bilgPara += total;
                lblBilgPara.Text = bilgPara.ToString();
                lblOyuncuPara.Text = oyucuPara.ToString();
            }
            else if (totalZarBir == totalZarIki)
            {
                if (oyun == 5)
                {
                    lblKasa.Text = (total / 2).ToString();
                    total = total / 2;
                }
                oyucuPara += total / 2;
                bilgPara += total / 2;
                lblBilgPara.Text = bilgPara.ToString();
                lblOyuncuPara.Text = oyucuPara.ToString();
            }
        }
        public int ResimAta() 
        {
            zarToplam = 0;
            zarNumara = rnd.Next(0, 6);
            zarToplam += (zarNumara+1);
            pcbZarBir.Image = ResimDizi[zarNumara];
            System.Threading.Thread.Sleep(50);
            zarNumara = rnd.Next(0, 6);
            zarToplam += (zarNumara+1);
            pcbZarIki.Image = ResimDizi[zarNumara];
            System.Threading.Thread.Sleep(50);
            return zarToplam;           
        }

        public void Kontrol() 
        {
            if (oyucuPara == 0) 
            
            {
                btnPlay.Enabled = false;
                MessageBox.Show(" !! KAYBETTİN !!");
                tmrOyunZamani.Stop();
               
                
            }
            if (bilgPara == 0) 
            {
                btnPlay.Enabled = false;
                MessageBox.Show("!! KAZANDIN !!");
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
                tmrOyunZamani.Stop();
            }

            if (oyucuPara<30 || bilgPara<30)
            {
                rbOtuz.Enabled = false;
            }
            if  (oyucuPara < 20 || bilgPara < 20) 
            {
                rbYirmi.Enabled = false;
            }
            if (oyucuPara<10 || bilgPara<10)
            {
                rbOn.Enabled = false;
                
            }
            if(oyucuPara>=10 && bilgPara>=10) 
            {
                rbOn.Enabled = true;
            }
            if (oyucuPara >= 20 && bilgPara >= 20)
            {
                rbYirmi.Enabled = true;
            }
            if (oyucuPara >= 30 && bilgPara >= 30)
            {
                rbOtuz.Enabled = true;

            }

        }
         
        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            
            if (oyun == 5)
                oyun = 0;
            sayac++;
            oyun++;
            lblOyunAdeti.Text = sayac.ToString();         
            totalZarBir = ResimAta();
            label1.Text = totalZarBir.ToString();          
            tmrOyunZamani.Start();
            
        }     
        private void Form1_Load(object sender, EventArgs e)
        {               
            ResimDizi[0] = Properties.Resources.zar1;
            ResimDizi[1] = Properties.Resources.zar2;
            ResimDizi[2] = Properties.Resources.zar3;
            ResimDizi[3] = Properties.Resources.zar4;
            ResimDizi[4] = Properties.Resources.zar5;
            ResimDizi[5] = Properties.Resources.zar6;           
            lblBilgPara.Text = bilgPara.ToString();
            lblOyuncuPara.Text = oyucuPara.ToString();       
        }
        private void tmrOyunZamani_Tick(object sender, EventArgs e)
        {

           

            totalZarIki = ResimAta();
            label2.Text = totalZarIki.ToString();
            lblBilgPara.Text = bilgPara.ToString();
            lblOyuncuPara.Text = oyucuPara.ToString();
            if (rbOn.Checked)
            {
                bilgPara = bilgPara - 10;
                oyucuPara = oyucuPara - 10;
                total = 20;
                if (rbBuyuk.Checked)
                {
                    BuyukKontrol();                 
                }
                if (rbKucuk.Checked)
                {
                    KucukKontrol();
                }
            }
            if (rbYirmi.Checked)
            {
                bilgPara = bilgPara - 20;
                oyucuPara = oyucuPara - 20;
                total = 40;
                if (rbBuyuk.Checked)
                {
                    BuyukKontrol();
                }
                if (rbKucuk.Checked)
                {
                    KucukKontrol();
                }
            }
            if (rbOtuz.Checked)
            {
                bilgPara = bilgPara - 30;
                oyucuPara = oyucuPara - 30;
                total = 60;
                if (rbBuyuk.Checked)
                {
                    BuyukKontrol();
                }
                if (rbKucuk.Checked)
                {
                    KucukKontrol();
                }
            }

            Kontrol();

            tmrOyunZamani.Stop();
        }     
    }
}
