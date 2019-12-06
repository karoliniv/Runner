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
    public partial class RegisterAsARunner : Form
    {
        public RegisterAsARunner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan y = Program.x - DateTime.Now;
            label3.Text = y.Days.ToString() + " дней " + y.Hours.ToString() + " часов " + y.Minutes.ToString() + " минут до старта марафона!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new RegisterAsARunner2()).ShowDialog();
            this.Show();
        }
    }
}
