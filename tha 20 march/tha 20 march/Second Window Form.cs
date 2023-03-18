using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace tha_20_march
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void benito (string name, string artist)
        {
            label1.Text = "Hi, my name is " + name +" and my favorite artist is " + artist;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void magic_Click(object sender, EventArgs e)
        {
            Form1 thirdform = new Form1();
            if (black.Checked)
            {
                thirdform.BackColor = Color.Black;
            }
            else if (white.Checked)
            {
                thirdform.BackColor = Color.White;
            }
            else if (gray.Checked)
            {
                thirdform.BackColor = Color.Gray;
            }
            else if (blue.Checked)
            {
                thirdform.BackColor = Color.Blue;
            }
            else if (green.Checked)
            {
                thirdform.BackColor = Color.Green;
            }
            if (pink.Checked)
            {
                thirdform.ForeColor = Color.Pink;
            }
            else if (purple.Checked)
            {
                thirdform.ForeColor= Color.Purple;
            }
            else if (red.Checked)
            {
                thirdform.ForeColor = Color.Red;
            }
            if (black.Checked == false && white.Checked == false && gray.Checked == false && blue.Checked == false && green.Checked== false)
            {
                MessageBox.Show("Input Background Color!");
            }
            if (pink.Checked==false && purple.Checked==false && red.Checked==false)
            {
                MessageBox.Show("Input Text Color!");
            }



            thirdform.Show();

        }

        private void agreement2_CheckedChanged(object sender, EventArgs e)
        {
            if (agreement2.Checked&& agreement3.Checked) 
            {
                magic.Enabled = true; 
            }
            else
            {
                magic.Enabled = false;
            }
        }

        private void agreement3_CheckedChanged(object sender, EventArgs e)
        {
            if (agreement2.Checked && agreement3.Checked)
            {
                magic.Enabled = true;
            }
            else
            {
                magic.Enabled = false;
            }
        }
    }
}
