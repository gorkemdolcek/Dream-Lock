using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DreamLock
{
    public partial class RecentHashes : Form
    {

        public RecentHashes()
        {
            hashLogClass hash = new hashLogClass();
            hashLogClass.checkdbFile();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
