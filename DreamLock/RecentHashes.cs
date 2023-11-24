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
            string selectedItem = listBox1.GetItemText(listBox1.SelectedItem);
            hashLogClass csvManager = new hashLogClass();
            List<FileRecord> readRecords = csvManager.ReadFromCsv();

            foreach (var record in readRecords)
            {
                if (record.Hash == selectedItem)
                {
                    fileNameLabel.Text ="File Name: "+ record.FileName;
                    hashTypeLabel.Text = "Hash Type: "+record.HashType;
                    hashValueLabel.Text = "Hash Value: "+record.Hash;
                    hashDateLabel.Text = "Hash Date: "+record.DateTime;
                }
            }

        }
    }
}
