using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phasee
{
    public partial class Group2 : Form
    {
        public Group2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDown7.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDown7.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown1.Text);
            int b = int.Parse(numericUpDown2.Text);
            int c = int.Parse(numericUpDown3.Text);
            int d = int.Parse(numericUpDown4.Text);
            int ea = int.Parse(numericUpDown5.Text);
            int f = int.Parse(numericUpDown6.Text);
            int n = int.Parse(numericUpDown7.Text);
            int k = 0;
            int outcome1;
            int raidai;
            int moneyy2 = int.Parse(money2.Text);
            if ((b + c) > 100000)
            {
                k = 100000;
            }
            else if ((b + c) < 100000)
            {
                k = b + c;
            }

            {
                outcome1 = (a + k + d + ea + n + f);
                textBox5.Text = outcome1.ToString();
                raidai = moneyy2 - outcome1;
                textBox7.Text = raidai.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group3 gr3 = new Group3();
            gr3.money3.Text = textBox7.Text;
            gr3.Show();
        }
    }
}
