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
    public partial class Group1 : Form
    {
        public Group1()
        {
            InitializeComponent();
        }

        private void Group1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = int.Parse(numericUpDown1.Text);
            int g = int.Parse(numericUpDown2.Text);
            int h = int.Parse(numericUpDown3.Text);
            int i = int.Parse(numericUpDown4.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int ex = 0;
            int outcome1;
            int raidai;
            int money2 = int.Parse(money1.Text);
            if (radioButton5.Checked == true)
            {
                a = a + 60000;
            }
            if (checkBox1.Checked == true)
            {
                b = b + 30000;
            }
            if (checkBox2.Checked == true)
            {
                c = c + 30000;
            }
            if (checkBox3.Checked == true)
            {
                d = d + 30000;
            }
            if (checkBox4.Checked == true)
            {
                ex = ex + 30000;
            }

            f = f * 30000;
            g = g * 60000;
            i = i * 60000;
            {
                outcome1 = a + b + c + ex + f + g + i + h;
                textBox5.Text = outcome1.ToString();
                raidai = money2- outcome1;
                textBox7.Text = raidai.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Group2 gr2 = new Group2();
            gr2.money2.Text = textBox7.Text;
            gr2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
