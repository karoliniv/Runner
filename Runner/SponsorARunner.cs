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

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox5.Text = " ";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox6.Text = " ";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 16;
        }
    }
}
