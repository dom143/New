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
    public partial class Group5 : Form
    {
        public Group5()
        {
            InitializeComponent();
        }
        public int lodd;
        public int moneyy5;
        public int outcome;
        public int pasee;
        public int afpasee;
        public int aflodd;


        private void button1_Click(object sender, EventArgs e)
        {
            int nation = int.Parse(numericUpDown1.Text);
            int edusport = int.Parse(numericUpDown2.Text);
            int book = int.Parse(numericUpDown3.Text);
            int otop = int.Parse(numericUpDown4.Text);
            int travalmain = int.Parse(numericUpDown5.Text);
            int travalsecond = int.Parse(numericUpDown6.Text);
            int spendhouse1 = int.Parse(numericUpDown7.Text);
            int spendcar1 = int.Parse(numericUpDown8.Text);
            int spendhouse2 = int.Parse(numericUpDown9.Text);
            int spendcar2 = int.Parse(numericUpDown10.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            moneyy5 = int.Parse(money5.Text);
            if ((travalmain + travalsecond) > 20000)
            {
                a = 20000;
            }
            else if ((travalmain + travalsecond) < 20000)
            {
                a = travalmain + travalsecond;
            }
            if ((spendhouse1 + spendcar1) > 100000)
            {
                b = 100000;
            }
            else if ((spendhouse1 + spendcar1) < 100000)
            {
                b = spendhouse1 + spendcar1;
            }
            if ((spendhouse2 + spendcar2) > 100000)
            {
                c = 100000;
            }
            else if ((spendhouse2 + spendcar2) < 100000)
            {
                c = spendhouse2 + spendcar2;
            }
            outcome = (nation + edusport + book + otop + a + b + c);
            textBox1.Text = outcome.ToString();
            lodd = moneyy5 - outcome;

            //คำนวณเงินจ่ายภาษี
            pasee = moneyy5 - outcome;
            if ( pasee > 5000000)
            {
                pasee = ((pasee * 35) / 100);
            }
            else if (pasee > 2000000)
            {
                pasee = ((pasee * 30) / 100);
            }
            else if (pasee > 1000000)
            {
                pasee = ((pasee * 25) / 100);
            }
            else if (pasee > 750000)
            {
                pasee = ((pasee * 20) / 100);
            }
            else if (pasee > 500000)
            {
                pasee = ((pasee * 15) / 100);
            }
            else if (pasee > 300000)
            {
                pasee = ((pasee * 10) / 100);
            }
            else if (pasee > 150000)
            {
                pasee = ((pasee * 5) / 100);
            }
            else
            {
                pasee = 0;
            }
            //Final fi1 = new Final();
            //fi.textBox1.Text = pasee.ToString();
            //fi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            afpasee = lodd - pasee;
            Final fi = new Final();
            fi.textBox5.Text = lodd.ToString();
            fi.textBox1.Text = pasee.ToString();
            fi.textBox2.Text = afpasee.ToString();
            fi.Show();
        }

        private void Group5_Load(object sender, EventArgs e)
        {

        }
    }
}
