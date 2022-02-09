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

namespace SuperMarket.GUI
{
   
    public partial class MARKET : Form
    {
        public MARKET()
        {
            InitializeComponent();
        }

        private void MARKET_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 LO =new Form1();
            this.Hide();
            LO.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUYING BU = new BUYING();
            this.Hide();
            BU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STORAGE ST = new STORAGE();
            this.Hide();
            ST.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BILLS BI = new BILLS();
            this.Hide();
            BI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SUPPLIES SU = new SUPPLIES();
            this.Hide();
            SU.Show();
        }
    }
}
