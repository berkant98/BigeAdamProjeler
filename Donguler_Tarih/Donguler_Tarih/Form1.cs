using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Tarih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGun.Items.Clear();

            for (int i = 1900; i <= 2015; i++)
            {
                cbYil.Items.Add(i.ToString());
            }

            for (int x = 1; x <= 12; x++)
            {
                if (x<10)
                {
                    cbAy.Items.Add("0" +x.ToString());

                }
                else cbAy.Items.Add(x.ToString());
            }
            for (int y = 1; y <= 31; y++)
            {
                if (y < 10)
                {
                    cbGun.Items.Add("0" +y.ToString());

                }
                else { cbGun.Items.Add(y.ToString()); }


            }

        }

        private void cbGun_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
