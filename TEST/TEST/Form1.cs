using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labshow_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            labshow.Text += labname.Text.ToString() + " " + txtname.Text.ToString() + "\n";
            labshow.Text += labage.Text.ToString()  + " " + txtage.Text.ToString() + "\n";
            labshow.Text += labtell.Text.ToString() + " " + txtphone.Text.ToString() + "\n";
            labshow.Text += labgender.Text.ToString() + " " + cbgender.Text.ToString() + "\n";
            labshow.Text += labcity.Text.ToString() + " " + cbcity.Text.ToString() + "\n";
        }
    }
}
