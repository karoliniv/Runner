using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class charity_i : UserControl
    {
        public charity_i(string name, string desc, string pic)
        {
            InitializeComponent();
            Title.Text = name;
            Description.Text = desc;
            Logo.Image = new Bitmap("pics/" + pic);
        }
    }
}
