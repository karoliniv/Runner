using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class SponsorARunner : Form
    {
        public SponsorARunner()
        {
            InitializeComponent();
            this.Load += SponsorARunner_Load;
        }

        private void SponsorARunner_Load(object sender, EventArgs e)
        {
            this.runnerTableAdapter.Fill(this.runnerDataSet.Runner);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
        }


        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = " ";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = " "; 
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //MessageBox.Show(now.Year.ToString()+now.Month.ToString());
            

            if(Convert.ToInt32(textBox7.Text) < now.Year)
            {
                MessageBox.Show("Wrong year");

                if (Convert.ToInt32(textBox6.Text) < now.Month)
                {
                    MessageBox.Show("Wrong mounth");
                }
            }
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = " ";
        }
    }
}
