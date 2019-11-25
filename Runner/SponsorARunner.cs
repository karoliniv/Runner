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

            textBoxMoney.TextChanged += textBoxMoney_TextChanged;
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

        private void textBoxMoney_Click(object sender, EventArgs e)
        {
            textBoxMoney.Text = " ";
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
            comboBoxRunner.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //MessageBox.Show(now.Year.ToString()+now.Month.ToString());

            if(Convert.ToInt32(maskedTextBox4.Text) < now.Year)
            {
                MessageBox.Show("Wrong year");

                if (Convert.ToInt32(maskedTextBox3.Text) < now.Month)
                {
                    MessageBox.Show("Wrong mounth");
                }
            }

            SponsorshipConfirmation x = new SponsorshipConfirmation();
            x.label12.Text = labelMoney.Text;
            x.labelRunner.Text = comboBoxRunner.Text;

            this.Close();
            x.ShowDialog();

        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new NameOfSponsor()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxMoney.Text);
            textBoxMoney.Text = Convert.ToString(a + 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxMoney.Text);
            textBoxMoney.Text = Convert.ToString(a - 10);
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            maskedTextBox3.Text = " ";
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            maskedTextBox4.Text = " ";
        }

        public void textBoxMoney_TextChanged(object sender, EventArgs e)
        {
            labelMoney.Text = textBoxMoney.Text + "$";
        }
    }
}
