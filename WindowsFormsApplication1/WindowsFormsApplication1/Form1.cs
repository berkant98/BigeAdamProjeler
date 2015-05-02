using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for (int i = 1; i < 100; i++)
            {
            
            if (i % 2 == 0 )
                lbListe.Items.Add(if.ToString());
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb.liste.Items.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
