using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamLock
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static void openit(string x)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + x);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            openit("https://www.youtube.com/watch?v=Y486GbXKN4g&ab_channel=Sekiz");
        }
    }
}
