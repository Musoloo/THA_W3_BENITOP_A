using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tha_20_march
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nextformbutton_Click(object sender, EventArgs e)
        {
            nextformbutton.Enabled = false;
            Form2 secondform = new Form2();
            secondform.Show();
            if (agreement.Checked == true && nextformbutton.Enabled == false)
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void agreement_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (agreement.Checked == true && nextformbutton.Enabled == false)
            {
                submit.Enabled=true;
            }
            else
            {
                submit.Enabled=false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (agreement.Checked)
            {
                submit.Enabled = true;
            }
            if (nametextbox.Text == "")
            {
                MessageBox.Show("Input Name!");
            }
            if (favoritetextbox.Text == "")
            {
                MessageBox.Show("Input Your Favorite Artist!");
            }
            Form2 secondform = new Form2();
            secondform.benito(nametextbox.Text, favoritetextbox.Text);
            if (nametextbox.Text!=""&&favoritetextbox.Text!="")
            {
                secondform.ShowDialog();
            }
         
                

        }


    }
}

