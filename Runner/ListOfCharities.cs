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
    public partial class ListOfCharities : Form
    {
        public ListOfCharities()
        {
            InitializeComponent();
            this.Load += ListOfCharities_Load;
        }

        private void ListOfCharities_Load(object sender, EventArgs e)
        {
            var charitys = new RunnerDataSetTableAdapters.CharityTableAdapter().GetData();

            for (int i = 0; i < charitys.Count; i++)
            {
                var el = charitys[i];
                var uc = new charity_i(el.CharityName, el.CharityDescription, el.CharityLogo);
                uc.Dock = DockStyle.Top;
                listChars.Controls.Add(uc);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfCharities_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runnerDataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.runnerDataSet.Runner);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan y = Program.x - DateTime.Now;
            label3.Text = y.Days.ToString() + " дней " + y.Hours.ToString() + " часов " + y.Minutes.ToString() + " минут до старта марафона!";

        }
    }
}
