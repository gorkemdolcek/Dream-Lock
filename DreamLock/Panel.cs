using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DreamLock
{
    public partial class Panel : Form
    {
        private string selectedFileName = "";
        private string safeSelectedFileName = "";
        private string safePublicKeySelectedFileName = "";
        private string PublicKeyselectedFileName = "";
        private string safePrivateKeySelectedFileName = "";
        private string PrivateKeyselectedFileName = "";
        private OpenFileDialog rsaPrivateKeyOpenFileDialog = new OpenFileDialog();
        private OpenFileDialog rsaPublicKeyOpenFileDialog = new OpenFileDialog();
        DialogResult result;
        DialogResult result2;
        //suraya degisken atmaktan cigerim soldu yemin ederim


        hashLogClass csvManager = new hashLogClass();
        hashingClass hash = new hashingClass();
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
                if (hashComboBox.Text == "MD2")
                {
                    string md2Hash = hash.CalculateMDHashofFile(selectedFileName, 2);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " MD2: " + md2Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "MD2", md2Hash, DateTime.Now);

                }
                else if (hashComboBox.Text == "MD4")
                {
                    string md4Hash = hash.CalculateMDHashofFile(selectedFileName, 4);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " MD4: " + md4Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "MD4", md4Hash, DateTime.Now);

                }
                else if (hashComboBox.Text == "MD5")
                {
                    string md5Hash = hash.CalculateMDHashofFile(selectedFileName, 5);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " MD5: " + md5Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "MD5", md5Hash, DateTime.Now);

                }
                else if (hashComboBox.Text == "SHA-1")
                {
                    string sha1Hash = hash.CalculateSHAHashofFile(selectedFileName, 1);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA1: " + sha1Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "SHA-1", sha1Hash, DateTime.Now);
                }
                else if (hashComboBox.Text == "SHA-224")
                {
                    string sha224Hash = hash.CalculateSHAHashofFile(selectedFileName, 224);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA224: " + sha224Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "SHA-224", sha224Hash, DateTime.Now);

                }
                else if (hashComboBox.Text == "SHA-256")
                {
                    string sha256Hash = hash.CalculateSHAHashofFile(selectedFileName, 256);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-256: " + sha256Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "SHA-256", sha256Hash, DateTime.Now);
                }
                else if (hashComboBox.Text == "SHA-384")
                {
                    string sha384Hash = hash.CalculateSHAHashofFile(selectedFileName, 384);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-384: " + sha384Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "SHA-384", sha384Hash, DateTime.Now);

                }
                else if (hashComboBox.Text == "SHA-512")
                {
                    string sha512Hash = hash.CalculateSHAHashofFile(selectedFileName, 512);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-512: " + sha512Hash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "SHA-512", sha512Hash, DateTime.Now);
                }
                else if (hashComboBox.Text == "RIPEMD128")
                {
                    string ripeMD128 = hash.CalculateRIPEMDofFile(selectedFileName, 128);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-128: " + ripeMD128 + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-128", ripeMD128, DateTime.Now);
                }
                else if (hashComboBox.Text == "RIPEMD160")
                {
                    string ripeMD160 = hash.CalculateRIPEMDofFile(selectedFileName, 160);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-160: " + ripeMD160 + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-160", ripeMD160, DateTime.Now);

                }
                else if (hashComboBox.Text == "RIPEMD256")
                {
                    string ripeMD256 = hash.CalculateRIPEMDofFile(selectedFileName, 256);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-256: " + ripeMD256 + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-256", ripeMD256, DateTime.Now);

                }
                else if (hashComboBox.Text == "RIPEMD320")
                {
                    string ripeMD320 = hash.CalculateRIPEMDofFile(selectedFileName, 320);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-320: " + ripeMD320 + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-320", ripeMD320, DateTime.Now);
                }
                else if (hashComboBox.Text == "Whirlpool")
                {
                    string whirlpoolHash = hash.CalculateWhirlPoolofFile(selectedFileName);
                    richTextBox1.Text += "File: " + safeSelectedFileName + " Whirlpool: " + whirlpoolHash + "\n";
                    csvManager.WriteToCsv(safeSelectedFileName, "Whirlpool", whirlpoolHash, DateTime.Now);
                }
            }
            else if (System.IO.Directory.Exists(selectedFileName))
            {
                string[] fileEntries = System.IO.Directory.GetFiles(selectedFileName);
                foreach (string fileName in fileEntries)
                    if (hashComboBox.Text == "MD2")
                    {
                        string md2Hash = hash.CalculateMDHashofFile(selectedFileName, 2);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " MD2: " + md2Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "MD2", md2Hash, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "MD4")
                    {
                        string md4Hash = hash.CalculateMDHashofFile(selectedFileName, 4);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " MD4: " + md4Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "MD4", md4Hash, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "MD5")
                    {
                        string md5Hash = hash.CalculateMDHashofFile(selectedFileName, 5);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " MD5: " + md5Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "MD5", md5Hash, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "SHA-1")
                    {
                        string sha1Hash = hash.CalculateSHAHashofFile(selectedFileName, 1);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " SHA1: " + sha1Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "SHA-1", sha1Hash, DateTime.Now);
                    }
                    else if (hashComboBox.Text == "SHA-224")
                    {
                        string sha224Hash = hash.CalculateSHAHashofFile(selectedFileName, 224);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " SHA224: " + sha224Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "SHA-224", sha224Hash, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "SHA-256")
                    {
                        string sha256Hash = hash.CalculateSHAHashofFile(selectedFileName, 256);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-256: " + sha256Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "SHA-256", sha256Hash, DateTime.Now);
                    }
                    else if (hashComboBox.Text == "SHA-384")
                    {
                        string sha384Hash = hash.CalculateSHAHashofFile(selectedFileName, 384);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-384: " + sha384Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "SHA-384", sha384Hash, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "SHA-512")
                    {
                        string sha512Hash = hash.CalculateSHAHashofFile(selectedFileName, 512);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " SHA-512: " + sha512Hash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "SHA-512", sha512Hash, DateTime.Now);
                    }
                    else if (hashComboBox.Text == "RIPEMD128")
                    {
                        string ripeMD128 = hash.CalculateRIPEMDofFile(selectedFileName, 128);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-128: " + ripeMD128 + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-128", ripeMD128, DateTime.Now);
                    }
                    else if (hashComboBox.Text == "RIPEMD160")
                    {
                        string ripeMD160 = hash.CalculateRIPEMDofFile(selectedFileName, 160);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-160: " + ripeMD160 + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-160", ripeMD160, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "RIPEMD256")
                    {
                        string ripeMD256 = hash.CalculateRIPEMDofFile(selectedFileName, 256);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-256: " + ripeMD256 + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-256", ripeMD256, DateTime.Now);

                    }
                    else if (hashComboBox.Text == "RIPEMD320")
                    {
                        string ripeMD320 = hash.CalculateRIPEMDofFile(selectedFileName, 320);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " RIPEMD-320: " + ripeMD320 + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-320", ripeMD320, DateTime.Now);
                    }
                    else if (hashComboBox.Text == "Whirlpool")
                    {
                        string whirlpoolHash = hash.CalculateWhirlPoolofFile(selectedFileName);
                        richTextBox1.Text += "File: " + safeSelectedFileName + " Whirlpool: " + whirlpoolHash + "\n";
                        csvManager.WriteToCsv(safeSelectedFileName, "Whirlpool", whirlpoolHash, DateTime.Now);
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

        private void textHash_menuItem_click(object sender, EventArgs e)
        {
            Form TextHashing = new TextHashing();
            TextHashing.ShowDialog(this);
        }

        private void generateRSAPair_click(object sender, EventArgs e)
        {
            if (encryptAlgorithmBox.Text == "RSA")
            {
                var rsa = new RSACryptoServiceProvider(2048);
                var buffer = new StringBuilder();
                buffer.AppendLine("-----BEGIN RSA PUBLIC KEY-----");
                buffer.AppendLine(Convert.ToBase64String(
                rsa.ExportRSAPublicKey(),
                Base64FormattingOptions.InsertLineBreaks));
                buffer.AppendLine("-----END RSA PUBLIC KEY-----");

                var buffer2 = new StringBuilder();
                buffer2.AppendLine("-----BEGIN RSA PRIVATE KEY-----");
                buffer2.AppendLine(Convert.ToBase64String(
                rsa.ExportRSAPrivateKey(),
                Base64FormattingOptions.InsertLineBreaks));
                buffer2.AppendLine("-----END RSA PRIVATE KEY-----");


                SaveFileDialog savePublicDialog = new SaveFileDialog();
                savePublicDialog.Filter = "RSA Public Key (*.pub)|*.pub|All Files (*.*)|*.*";
                if (savePublicDialog.ShowDialog() == DialogResult.OK)
                {
                    string publicKeyPath = savePublicDialog.FileName;
                    StreamWriter Kayit = new StreamWriter(savePublicDialog.FileName);
                    Kayit.WriteLine(buffer);
                    Kayit.Close();
                }
                SaveFileDialog savePrivateDialog = new SaveFileDialog();
                savePrivateDialog.Filter = "RSA Private Key (*.pem)|*.pem|All Files (*.*)|*.*";
                if (savePrivateDialog.ShowDialog() == DialogResult.OK)
                {
                    string privateKeyPath = savePrivateDialog.FileName;
                    StreamWriter Kayit = new StreamWriter(savePrivateDialog.FileName);
                    Kayit.WriteLine(buffer2);
                    Kayit.Close();
                }
            }

        }

        private void openPublicKey_click(object sender, EventArgs e)
        {
            rsaPublicKeyOpenFileDialog.Title = "Dosya Seç";
            rsaPublicKeyOpenFileDialog.Filter = "Public Key (*.pub)|*.pub|All Files (*.*)|*.*";
            rsaPublicKeyOpenFileDialog.RestoreDirectory = true;
            result=rsaPublicKeyOpenFileDialog.ShowDialog(this);
            safePublicKeySelectedFileName = rsaPublicKeyOpenFileDialog.SafeFileName;
            PublicKeyselectedFileName = rsaPublicKeyOpenFileDialog.FileName;
            publicKeyLabel.Text = "Selected File: " + safePublicKeySelectedFileName;
        }

        private void openPrivateKey_click(object sender, EventArgs e)
        {
            rsaPrivateKeyOpenFileDialog.Title = "Dosya Seç";
            rsaPrivateKeyOpenFileDialog.Filter = "Private Key (*.pem)|*.pem|All Files (*.*)|*.*";
            rsaPrivateKeyOpenFileDialog.RestoreDirectory = true;
            result2=rsaPrivateKeyOpenFileDialog.ShowDialog(this);
            safePrivateKeySelectedFileName = rsaPrivateKeyOpenFileDialog.SafeFileName;
            PrivateKeyselectedFileName = rsaPrivateKeyOpenFileDialog.FileName;
            privateKeyLabel.Text = "Selected File: " + safePrivateKeySelectedFileName;
        }

        private void encrypt_click(object sender, EventArgs e)
        {
            if (result!= DialogResult.OK)
            {
                MessageBox.Show("You Should Select a Public Key for Encryption!");
            }
        }

        private void decrypt_click(object sender, EventArgs e)
        {
            if (result2 != DialogResult.OK)
            {
                MessageBox.Show("You Should Select a Private Key for Encryption!");
            }
        }
    }

}
