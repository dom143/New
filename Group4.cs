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
    public partial class Group4 : Form
    {
        public Group4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money4 = int.Parse(textBox1.Text);
            int outcome1;
            {
                outcome1 = ((money4 * 10) / 100);
                textBox2.Text = outcome1.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tan1 = int.Parse(textBox7.Text);
            int tan2 = int.Parse(textBox10.Text);
            int outcome4;
            int tenper = int.Parse(textBox2.Text);
            int onehan = int.Parse(textBox1.Text);
            int lod;
            int raidai;
            {
                outcome4 = tan1 + tan2;
                textBox11.Text = outcome4.ToString();
            }

            if (outcome4 > tenper)
            {
                lod = tenper;
            }
            else
            {
                lod = outcome4;
            }
            textBox12.Text = lod.ToString();
            raidai = onehan - lod;
            textBox13.Text = raidai.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int edu = int.Parse(textBox3.Text);
            int sport = int.Parse(textBox4.Text);
            int hos = int.Parse(textBox5.Text);
            int sata = int.Parse(textBox6.Text);
            int outcome2;
            {
                outcome2 = ((edu*2) + (sport*2) + (hos*2) + (sata*2));
                textBox7.Text = outcome2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tan = int.Parse(textBox8.Text);
            int outok = int.Parse(textBox9.Text);
            int pak = int.Parse(numericUpDown1.Text);
            int outcome3;
            {
                outcome3 = tan + outok + pak;
                textBox10.Text = outcome3.ToString();
            }
        }

        private void Group4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group5 gr5 = new Group5();
            gr5.money5.Text = textBox13.Text;
            gr5.Show();
        }
    }
}
