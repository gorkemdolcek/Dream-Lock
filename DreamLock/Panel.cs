using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamLock
{
    public partial class Panel : Form
    {
        private string selectedFileName;
        private string safeSelectedFileName;
        public Panel()
        {
            InitializeComponent();
            splitContainer1 = new SplitContainer();
            splitContainer1.Orientation = Orientation.Vertical;
        }

        private void AESKeyStorage_menuItem_click(object sender, EventArgs e)
        {
            Form AESKeyStorage = new AESKeyStorage();
            AESKeyStorage.ShowDialog(this);
        }

        private void RSAKeyStorage_menuItem_click(object sender, EventArgs e)
        {
            Form RsaKeyStorage = new RSAKeyStorage();
            RsaKeyStorage.ShowDialog(this);
        }
        private void Panel_Load(object sender, EventArgs e)
        {
            //splitContainer1 = new SplitContainer();
            //plitContainer1.Orientation = Orientation.Vertical;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            Form FormAbout = new About();
            FormAbout.ShowDialog(this);
        }

        private void RecentHashes_menuItem_click(object sender, EventArgs e)
        {
            Form RecentHashes = new RecentHashes();
            RecentHashes.ShowDialog(this);
        }

        private void virusTotalRecentHashes_menuItem_click(object sender, EventArgs e)
        {
            Form virusTotal = new VirusTotalRecentHashes();
            virusTotal.ShowDialog(this);
        }

        private void switchToOldAlgorithms_menuItem_click(object sender, EventArgs e)
        {
            this.Hide();
            Form OldAlgorithms = new OldAlgorithms();
            OldAlgorithms.ShowDialog(this);
            this.Close();
        }

        private void exit_menuItem_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog_menuItem_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.Filter = "Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog(this);
            safeSelectedFileName = openFileDialog1.SafeFileName;
            selectedFileName = openFileDialog1.FileName;
            label1.Text = "Selected File: " + safeSelectedFileName;

        }

        private void openFolderDialog_menuItem_click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog(this);
            selectedFileName = folderBrowserDialog1.SelectedPath;
            label1.Text = "Selected Folder: " + selectedFileName;
        }


        private void hashItButton_click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(selectedFileName))
            {
                hashingClass hash = new hashingClass();
                if (hashComboBox.Text == "MD2")
                {
                    string md2Hash = hash.CalculateMDHashofFile(selectedFileName, 2);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " MD2: " + md2Hash + "\n";
                }
                else if (hashComboBox.Text == "MD4")
                {
                    string md4Hash = hash.CalculateMDHashofFile(selectedFileName, 4);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " MD4: " + md4Hash + "\n";
                }
                else if (hashComboBox.Text == "MD5")
                {
                    string md5Hash = hash.CalculateMDHashofFile(selectedFileName, 5);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " MD5: " + md5Hash + "\n";
                }
                else if (hashComboBox.Text == "SHA-1")
                {
                    string sha1Hash = hash.CalculateSHAHashofFile(selectedFileName, 1);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA1: " + sha1Hash + "\n";
                }
                else if (hashComboBox.Text == "SHA-224")
                {
                    string sha224Hash = hash.CalculateSHAHashofFile(selectedFileName, 224);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA224: " + sha224Hash + "\n";
                }
                else if (hashComboBox.Text == "SHA-256")
                {
                    string sha256Hash = hash.CalculateSHAHashofFile(selectedFileName, 256);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-256: " + sha256Hash + "\n";
                }
                else if (hashComboBox.Text == "SHA-384")
                {
                    string sha384Hash = hash.CalculateSHAHashofFile(selectedFileName, 384);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-384: " + sha384Hash + "\n";
                }
                else if (hashComboBox.Text == "SHA-512")
                {
                    string sha512Hash = hash.CalculateSHAHashofFile(selectedFileName, 512);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-512: " + sha512Hash + "\n";
                }
                else if (hashComboBox.Text == "RIPEMD128")
                {
                    string ripeMD128 = hash.CalculateRIPEMDofFile(selectedFileName, 128);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-128: " + ripeMD128 + "\n";
                }
                else if (hashComboBox.Text == "RIPEMD160")
                {
                    string ripeMD160 = hash.CalculateRIPEMDofFile(selectedFileName, 160);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-160: " + ripeMD160 + "\n";
                }
                else if (hashComboBox.Text == "RIPEMD256")
                {
                    string ripeMD256 = hash.CalculateRIPEMDofFile(selectedFileName, 256);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-256: " + ripeMD256 + "\n";
                }
                else if (hashComboBox.Text == "RIPEMD320")
                {
                    string ripeMD320 = hash.CalculateRIPEMDofFile(selectedFileName, 320);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-320: " + ripeMD320 + "\n";
                }
                else if (hashComboBox.Text == "Whirlpool")
                {
                    string whirlpoolHash = hash.CalculateWhirlPoolofFile(selectedFileName);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " Whirlpool: " + whirlpoolHash + "\n";
                }
            }
            else if (System.IO.Directory.Exists(selectedFileName))
            {
                string[] fileEntries=System.IO.Directory.GetFiles(selectedFileName);
                hashingClass hash = new hashingClass();
                foreach (string fileName in fileEntries)
                if (hashComboBox.Text == "MD2")
                    {
                        string md2Hash = hash.CalculateMDHashofFile(fileName, 2);
                        richTextBox1.Text += "File: " + fileName + " MD2: " + md2Hash + "\n";
                    }
                    else if (hashComboBox.Text == "MD4")
                    {
                        string md4Hash = hash.CalculateMDHashofFile(fileName, 4);
                        richTextBox1.Text += "File: " + fileName + " MD4: " + md4Hash + "\n";
                    }
                    else if (hashComboBox.Text == "MD5")
                    {
                        string md5Hash = hash.CalculateMDHashofFile(fileName, 5);
                        richTextBox1.Text += "File: " + fileName + " MD5: " + md5Hash + "\n";
                    }
                    else if (hashComboBox.Text == "SHA-1")
                    {
                        string sha1Hash = hash.CalculateSHAHashofFile(fileName, 1);
                        richTextBox1.Text += "File: " + fileName + " SHA1: " + sha1Hash + "\n";
                    }
                    else if (hashComboBox.Text == "SHA-224")
                    {
                        string sha224Hash = hash.CalculateSHAHashofFile(fileName, 224);
                        richTextBox1.Text += "File: " + fileName + " SHA224: " + sha224Hash + "\n";
                    }
                    else if (hashComboBox.Text == "SHA-256")
                    {
                        string sha256Hash = hash.CalculateSHAHashofFile(fileName, 256);
                        richTextBox1.Text += "File: " + fileName + " SHA-256: " + sha256Hash + "\n";
                    }
                    else if (hashComboBox.Text == "SHA-384")
                    {
                        string sha384Hash = hash.CalculateSHAHashofFile(fileName, 384);
                        richTextBox1.Text += "File: " + fileName + " SHA-384: " + sha384Hash + "\n";
                    }
                    else if (hashComboBox.Text == "SHA-512")
                    {
                        string sha512Hash = hash.CalculateSHAHashofFile(fileName, 512);
                        richTextBox1.Text += "File: " + fileName + " SHA-512: " + sha512Hash + "\n";
                    }
                    else if (hashComboBox.Text == "RIPEMD128")
                    {
                        string ripeMD128 = hash.CalculateRIPEMDofFile(fileName, 128);
                        richTextBox1.Text += "File: " + fileName + " RIPEMD-128: " + ripeMD128 + "\n";
                    }
                    else if (hashComboBox.Text == "RIPEMD160")
                    {
                        string ripeMD160 = hash.CalculateRIPEMDofFile(fileName, 160);
                        richTextBox1.Text += "File: " + fileName + " RIPEMD-160: " + ripeMD160 + "\n";
                    }
                    else if (hashComboBox.Text == "RIPEMD256")
                    {
                        string ripeMD256 = hash.CalculateRIPEMDofFile(fileName, 256);
                        richTextBox1.Text += "File: " + fileName + " RIPEMD-256: " + ripeMD256 + "\n";
                    }
                    else if (hashComboBox.Text == "RIPEMD320")
                    {
                        string ripeMD320 = hash.CalculateRIPEMDofFile(fileName, 320);
                        richTextBox1.Text += "File: " + fileName + " RIPEMD-320: " + ripeMD320 + "\n";
                    }
                    else if (hashComboBox.Text == "Whirlpool")
                    {
                        string whirlpoolHash = hash.CalculateWhirlPoolofFile(fileName);
                        richTextBox1.Text += "File: " + fileName + " Whirlpool: " + whirlpoolHash + "\n";
                    }
            }

        }
        /*
         * Son vuslattan beri ne ses ne seda
         * Edin Vio’ya selam rest in peace Beta
         * Rest in peace Maestro yaktım bi’ çerağ
        */


        private void saveResults_menuItem_click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            saveFileDialog1.Title = "Metin Dosyasını Kaydet";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                    }

                    MessageBox.Show("Dosya başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) //burda niye exception var???????????
                {// he tamam zorunluymus
                    MessageBox.Show("Dosya kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hashAll_click(object sender, EventArgs e)
        {
            hashingClass hash = new hashingClass();
            if (System.IO.File.Exists(selectedFileName))
            {
                richTextBox1.Text += hash.hashAll(selectedFileName, safeSelectedFileName);
            }
            else if (System.IO.Directory.Exists(selectedFileName))
            {
                string[] fileEntries = System.IO.Directory.GetFiles(selectedFileName);
                foreach (string fileName in fileEntries)
                        richTextBox1.Text += hash.hashAll(fileName, fileName);
            }
                
        }

        private void clear_menuItem_click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }

}
