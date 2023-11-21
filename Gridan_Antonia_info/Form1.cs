using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gridan_Antonia_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 meridional = new Form2();
            meridional.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 test = new Form5();
            test.ShowDialog();
        }

        private void orientali_Click(object sender, EventArgs e)
        {
            Form3 oriental = new Form3();
            oriental.ShowDialog();
        }

        private void occidentali_Click(object sender, EventArgs e)
        {
            Form4 occidental = new Form4();
            occidental.ShowDialog();
        }
    }
}
