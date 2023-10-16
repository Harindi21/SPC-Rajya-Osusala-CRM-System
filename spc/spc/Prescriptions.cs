using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spc
{
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            stock s = new stock();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Delivery d = new Delivery();
           d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Notifications n = new Notifications();
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Prescriptions p = new Prescriptions();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            staff i = new staff();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 i = new Form1();
            i.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            home i = new home();
            i.Show();
        }
    }
}
