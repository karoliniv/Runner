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
    public partial class RegisterAsARunner2 : Form
    {
        public RegisterAsARunner2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan y = Program.x - DateTime.Now;
            label12.Text = y.Days.ToString() + " дней " + y.Hours.ToString() + " часов " + y.Minutes.ToString() + " минут до старта марафона!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterAsARunner2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runnerDataSet2.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.runnerDataSet2.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runnerDataSet2.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.runnerDataSet2.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runnerDataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.runnerDataSet1.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runnerDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.runnerDataSet.Gender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            else if (String.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }


        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox2.TextLength > 5)
            {
                bool eng = true;
                bool num = false;
                bool letter = false;
                bool symb = false;

                for (int i = 0; i < maskedTextBox2.TextLength; i++)
                {
                    if (maskedTextBox2.Text[i] >= 'А' && maskedTextBox2.Text[i] <= 'Я') eng = false;
                    if (maskedTextBox2.Text[i] >= '0' && maskedTextBox2.Text[i] <= '9') num = true;
                    if (maskedTextBox2.Text[i] >= 'A' && maskedTextBox2.Text[i] <= 'Z') letter = true;
                    if (maskedTextBox2.Text[i] == '!' || maskedTextBox2.Text[i] <= '@' ||
                        maskedTextBox2.Text[i] == '#' || maskedTextBox2.Text[i] <= '$' ||
                        maskedTextBox2.Text[i] == '%' || maskedTextBox2.Text[i] <= '^') symb = true;
                }

                if (!eng)
                    MessageBox.Show("Доступна только английская раскладка!");
                else if (!num)
                    MessageBox.Show("Добавьте хотя бы одну цифру!");
                else if (!letter)
                    MessageBox.Show("Добавьте хотя бы одну прописную букву!");
                else if (!symb)
                    MessageBox.Show("Добавьте хотя бы однин символ из списка: !@#$%^");

                if (eng && num && letter && symb)
                {

                }
            }

            else
            {
                MessageBox.Show("Длина пароля меньше допустимого! Введите минимум 6 символов.");
                maskedTextBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == maskedTextBox2.Text)
            {

            }

            else
            {
                MessageBox.Show("Пароли не совпадают!");
                textBox1.Text = "";
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            DateTime dateBLYAT = DateTime.Now;
            dateBLYAT.AddYears(-10);
            if (dateBLYAT.Year >= 0)
            {
                if (dateBLYAT.Year >= 0)
                {

                }
            }

            else
            {
                MessageBox.Show("Некоректная дата рождения");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();

            x.Filter = "Image files(*.BMP, *.JPG, *.GIF, *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|All files(*.*)|*.*";


            if (x.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox3.Image = new Bitmap(x.FileName);
                    textBox4.Text = x.SafeFileName;
                }

                catch
                {
                    MessageBox.Show("Невозможно выбрать данный файл", "Ошибка");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
