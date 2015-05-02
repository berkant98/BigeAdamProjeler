using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngüler_Faktöriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFaktoriyelHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 1;
            int girilenSayi = Convert.ToInt32(txtDeger.Text);
            for (int i = 1; i <= girilenSayi; i++)
                toplam = toplam * i;
            MessageBox.Show(toplam.ToString());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int toplam = 1;
            int girilenSayi = Convert.ToInt32(txtDeger.Text);
            int i=1;
            while (i <= girilenSayi)
            {
                toplam = toplam * i;
                i++;
            }
            MessageBox.Show(toplam.ToString());
        

        }

        private void btn3_Click(object sender, EventArgs e)
        {    
           
            int girilenSayi = Convert.ToInt32(txtDeger.Text);
            int toplam = 1;
            int h1;
            for (int x = 1; x <= girilenSayi; x++ )
            {
                toplam = toplam * x;
               
            }
            MessageBox.Show(toplam.ToString());
        
        }
    }
}
  
