using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void addNewKeypair_click(object sender, EventArgs e)
        {

            string keySize = "2048";
            int keysize2 = Int32.Parse(keySize);
            var rsa = new RSACryptoServiceProvider(keysize2);
            string buffer = rsa.ToXmlString(false);
            string buffer2 = rsa.ToXmlString(true);

            SaveFileDialog savePublicDialog = new SaveFileDialog();
            savePublicDialog.Filter = "C# RSA Public Key (*.xml)|*.xml|All Files (*.*)|*.*";
            if (savePublicDialog.ShowDialog() == DialogResult.OK)
            {
                string publicKeyPath = savePublicDialog.FileName;
                StreamWriter Kayit = new StreamWriter(savePublicDialog.FileName);
                Kayit.WriteLine(buffer);
                Kayit.Close();
                rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
                csvManager2.checkdbFile();
                csvManager2.WriteToCsv("Public", Path.GetFileName(savePublicDialog.FileName), savePublicDialog.FileName, DateTime.Now);


            }
            SaveFileDialog savePrivateDialog = new SaveFileDialog();
            savePrivateDialog.Filter = "C# RSA Private Key (*.xml)|*.xml|All Files (*.*)|*.*";
            if (savePrivateDialog.ShowDialog() == DialogResult.OK)
            {
                string privateKeyPath = savePrivateDialog.FileName;
                StreamWriter Kayit = new StreamWriter(savePrivateDialog.FileName);
                Kayit.WriteLine(buffer2);
                Kayit.Close();
                rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
                csvManager2.checkdbFile();
                csvManager2.WriteToCsv("Private", Path.GetFileName(savePrivateDialog.FileName), savePrivateDialog.FileName, DateTime.Now);
            }
            keyList.Items.Clear();

            rsaKeyStorageManager csvManager3 = new rsaKeyStorageManager();
            List<FileRecord2> readRecords2 = csvManager3.ReadFromCsv();

            foreach (var record in readRecords2)
            {
                ListViewItem item2 = new ListViewItem(record.keyType);
                item2.SubItems.Add(record.keyName);
                item2.SubItems.Add(record.keySavedLocation);
                item2.SubItems.Add(record.keyCreationDate);
                keyList.Items.Add(item2);
            }
        }

        private void deletePairFromRSAStorage_click(object sender, EventArgs e)
        {
            rsaKeyStorageManager csvManager3 = new rsaKeyStorageManager();
            List<FileRecord2> readRecords = csvManager3.ReadFromCsv();
            foreach(var record in  readRecords)
            {
                try
                {
                    if (keyList.SelectedItems[0].SubItems[1].Text == record.keyName)
                    {
                        csvManager3.DeleteRowByKeyname(keyList.SelectedItems[0].SubItems[1].Text);

                    }
                }
                catch { MessageBox.Show("Invalid"); }
            }
            keyList.Items.Clear();
            List<FileRecord2> readRecords2 = csvManager3.ReadFromCsv();

            foreach (var record in readRecords2)
            {
                ListViewItem item2 = new ListViewItem(record.keyType);
                item2.SubItems.Add(record.keyName);
                item2.SubItems.Add(record.keySavedLocation);
                item2.SubItems.Add(record.keyCreationDate);
                keyList.Items.Add(item2);
            }

        }
    }
}
