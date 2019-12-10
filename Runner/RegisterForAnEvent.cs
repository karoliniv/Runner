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
    public partial class RegisterForAnEvent : Form
    {
        public RegisterForAnEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Main()).ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

            }
            else
            {
                MessageBox.Show("Выберите вид марафона!");
            }

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {

            }
            else
            {
                MessageBox.Show("Выберите вариант комплекта!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "$";
            if (Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("Введите положительное число!");
                return;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan y = Program.x - DateTime.Now;
            label11.Text = y.Days.ToString() + " дней " + y.Hours.ToString() + " часов " + y.Minutes.ToString() + " минут до старта марафона!";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForAnEvent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runnerDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.runnerDataSet.Charity);

        }

        private void label10_Click(object sender, EventArgs e)
        {


            int forth = 0;
            int fifth = 20;
            int sixth = 45;
            int result = 0;

            if (radioButton1.Checked)
            {
                result = result + forth;
                label10.Text = result + "$";
            }
            if (radioButton2.Checked)
            {
                result = result + fifth;
                label10.Text = result + "$";
            }
            if (radioButton3.Checked)
            {
                result = result + sixth;
                label10.Text = result + "$";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int first = 145;
            int second = 75;
            int third = 20;
            int forth = 0;
            int fifth = 20;
            int sixth = 45;
            int result = 0;

            if (checkBox1.Checked)
            {
                result = result + first;
                if (checkBox2.Checked)
                {
                    result = result + second;
                    if (checkBox3.Checked)
                    {
                        result = result + third;
                        label10.Text = result + "$";
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int first = 145;
            int second = 75;
            int third = 20;
            int forth = 0;
            int fifth = 20;
            int sixth = 45;
            int result = 0;

            if (checkBox2.Checked)
            {
                result = result + second;
                if (checkBox1.Checked)
                {
                    result = result + first;
                    if (checkBox3.Checked)
                    {
                        result = result + third;
                        label10.Text = result + "$";
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            int third = 20;
            int result = 0;

            if (checkBox3.Checked)
            {
                result = result + third;
                label10.Text = result + "$";
            }
        }
    }
}
