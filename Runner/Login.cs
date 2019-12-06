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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RunnerDataSetTableAdapters.UserTableAdapter x = new RunnerDataSetTableAdapters.UserTableAdapter();
            RunnerDataSet.UserDataTable y = 
            x.BLYA(textBox1.Text, textBox4.Text);
            //MessageBox.Show(y.Count.ToString());
            //x.Select("Email = '" + textBox1.Text + "' AND Password = '" + textBox4.Text + "'");

            DataRow[] z = y.Select();



            if(y.Count == 0)
            {
                MessageBox.Show("Логин и/или пароль введен/введены неправильно!");
                return;
            }

            if((String)(z[0].ItemArray[4]) == "R")
            {
                 this.Hide();
                (new RunnerMenu()).ShowDialog();
                 this.Show();
            }

            if((String)(z[0].ItemArray[4]) == "A")
            {
                this.Hide();
                (new AdministratorMenu()).ShowDialog();
                this.Show();
            }

            if((String)(z[0].ItemArray[4]) == "C")
            {
                this.Hide();
                (new CoordinatorMenu()).ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Логин и/или пароль введен/введены неправильно!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan y = Program.x - DateTime.Now;
            label3.Text = y.Days.ToString() + " дней " + y.Hours.ToString() + " часов " + y.Minutes.ToString() + " минут до старта марафона!";
        }
    }
}
