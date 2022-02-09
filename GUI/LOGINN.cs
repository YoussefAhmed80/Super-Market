using SuperMarket.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void show_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.SetToolTip(show,"Show Password");
        }

        private void hide_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.SetToolTip(hide, "Hiden Password");
        }

        private void show_Click(object sender, EventArgs e)
        {
            show.Hide();
            Pass.UseSystemPasswordChar = false;
            hide.Show();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Hide();
            Pass.UseSystemPasswordChar = true;
            show.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            MARKET MK = new MARKET();
            this.Hide();
            MK.Show();
        }
    }
}
