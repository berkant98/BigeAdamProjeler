using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngüler_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastgeleSayi_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(1, 101);
            label1.Text = rastgeleSayi.ToString();
        }
        
        private void tmrWhile_Tick(object sender, EventArgs e);
        
        if (label1.Text == "")
        return;
        int deger = Convert.ToInt32(label1.Text);
        while (deger<60 && deger > 40)
    {
        label.Message.Text= "Rastgele deger 40 ile 60 arasında.";

        donguSayaci++;
        if (donguSayaci > 10)
        break;
    }
    }
    }

}
