using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngüler_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            int xSirasi= Convert.ToInt32(nmrcUpDwn1.Value);
            int ySirasi = Convert.ToInt32(nmrcUpDwn2.Value);

            for (int x = 0; x < xSirasi; x++)
            {
                for (int y = 0; y < ySirasi; y++)
                {
                    Button btn = new Button();
                    scAnaPanel.Panel2.Controls.Add(btn);
                    btn.Size = new System.Drawing.Size(50, 50);
                    btn.Location = getLocation (x, y);
                    btn.Text = "-";
                    btn.Click += btn_Click;
                    btn.Tag= 0;

                    Koltuk koltuk = new Koltuk();
                    koltuk.xKonumu=x;
                    koltuk.yKonumu=y;
                    koltuk.cinsiyetTipi=CinsiyetTipi.TanimliDegil;
                        btn.Tag= koltuk;
                    scAnaPanel.Panel2.Controls.Add(btn);

                }
                
            }

        }
        class Koltuk
        {
           public int xKonumu;
           public int yKonumu;
           public CinsiyetTipi cinsiyetTipi;

            
        }
        enum CinsiyetTipi
        {
        TanimliDegil=0,
        Erkek=1,
        Kadin=2,
        Hiçbiri=3
          }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Koltuk koltuk=((Koltuk)btn.Tag);
            CinsiyetTipi cinsiyetTipi=koltuk.cinsiyetTipi;
            int xKonumu = koltuk.xKonumu;
            int yKonumu = koltuk.yKonumu;

            Koltuk yanKoltuk = YanKoltuguGetir(koltuk);

             if (cinsiyetTipi==CinsiyetTipi.TanimliDegil)

            if (rbErkek.Checked)
            {
                (sender as Button).Text = "E";
                btn.BackColor = Color.Blue;
                koltuk.cinsiyetTipi = CinsiyetTipi.Erkek;
                btn.Tag = koltuk;
            }
            else if (rbKadin.Checked) 
            {
                (sender as Button).Text = "K";
                btn.BackColor = Color.Pink;
                koltuk.cinsiyetTipi = CinsiyetTipi.Kadin;
                btn.Tag = koltuk;
                   
            }
            else if (rbHicbiri.Checked)
            {
            (sender as Button).Text="H";
            btn.BackColor = Color.Purple;
            koltuk.cinsiyetTipi = CinsiyetTipi.Hiçbiri;
            btn.Tag = koltuk;

            }
            else
            {
                btn.Text="-";
            }


        }

        private Koltuk YanKoltuguGetir(Koltuk koltuk)
        {
            Koltuk yanKoltuk = new Koltuk();
            foreach (Control control in scAnaPanel.Panel2.Controls)
            {
                if (control is Button)
                {
                    Button btn = (control as Button);
                    Koltuk donguKoltugu = ((Koltuk)btn.Tag);
                    if (koltuk.yKonumu==donguKoltugu.yKonumu)
                }
            }
        }

        private Point getLocation(int x, int y)

        {

            Point p = new Point();
            p.X = x *50 ;
            p.Y = y*50;

            return p;
            
        }
    }
}
