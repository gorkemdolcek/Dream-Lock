using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DreamLock
{
    public partial class RSAKeyStorage : Form
    {
        public RSAKeyStorage()
        {

            InitializeComponent();
            rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
            List<FileRecord2> readRecords = csvManager2.ReadFromCsv();
            int k = 0;

            foreach (var record in readRecords)
            {
                ListViewItem item = new ListViewItem(record.keyType);
                item.SubItems.Add(record.keyName);
                item.SubItems.Add(record.keySavedLocation);
                item.SubItems.Add(record.keyCreationDate);
                keyList.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
