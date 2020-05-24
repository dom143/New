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
    public partial class Group3 : Form
    {
        public Group3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int property2558 = int.Parse(numericUpDown2.Text);
            int taxhouse = int.Parse(numericUpDown1.Text);
            int outcome2558;
            int outcome4;
            int outcomefinal2558;
            int moneyy3 = int.Parse(money3.Text);
            int raidai;
            {
                outcome2558 = (property2558 * 20) / 100;
                textBox1.Text = outcome2558.ToString();
                outcome4 = (outcome2558 * 4) / 20;
                textBox2.Text = outcome4.ToString();
                outcomefinal2558 = (taxhouse + outcome4);
                textBox3.Text = outcomefinal2558.ToString();
                raidai = moneyy3 - outcomefinal2558;
                textBox7.Text = raidai.ToString(); ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int property = int.Parse(numericUpDown3.Text);
            int taxhouse = int.Parse(numericUpDown1.Text);
            int outcome2562;
            int outcomefinal2562;
            int a = 0;
            int moneyy3 = int.Parse(money3.Text);
            int raidai;
            if (property < 5000001)
            {
                a = 200000;
            }
            else if (property > 5000000)
            {
                a = 200000;
            }
            else if (property < 200000)
            {
                a = property;
            }
            outcome2562 = a;
            textBox4.Text = outcome2562.ToString();
            outcomefinal2562 = taxhouse + a;
            textBox5.Text = outcomefinal2562.ToString();
            raidai = moneyy3 - outcomefinal2562;
            textBox7.Text = raidai.ToString(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group4 gr4 = new Group4();
            gr4.textBox1.Text = textBox7.Text;
            gr4.Show();
        }

        private void money3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
