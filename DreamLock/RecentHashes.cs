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
using System.Data.Common;
using System.Windows.Forms.Design;


namespace DreamLock
{
    public partial class RecentHashes : Form
    {

        public RecentHashes()
        {
            hashLogClass csvManager = new hashLogClass();
            hashLogClass.checkdbFile();
            List<FileRecord> readRecords = csvManager.ReadFromCsv();
            InitializeComponent();
            foreach (var record in readRecords)
            {
                listBox1.Items.Add($"{record.Hash}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
        }
    }
}
