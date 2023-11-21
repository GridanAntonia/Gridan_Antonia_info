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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p=0;
            if (v1.Checked == true)
                p++;
            if (radioButton2.Checked == true) p++;
            if (radioButton5.Checked == true) p++;
            MessageBox.Show("Scorul tau este de " + p.ToString() + " puncte");
        }
    }
}
