using Org.BouncyCastle.Utilities;
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
        private string sonuc;
        rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
        //suraya degisken atmaktan cigerim soldu yemin ederim


        hashLogClass csvManager = new hashLogClass();

        hashingClass hash = new hashingClass();
        public Panel()
        {
            InitializeComponent();
            splitContainer1 = new SplitContainer();
            splitContainer1.Orientation = Orientation.Vertical;
        }
        private void RSAKeyStorage_menuItem_click(object sender, EventArgs e)
        {
            helpLabel.Text = "You've opened the RSA Storage menu. Here, you can access all of your keys.";
            rsaKeyStorageManager csvManager3 = new rsaKeyStorageManager();
            csvManager3.checkdbFile();
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
            helpLabel.Text = "You've opened the Recent Hashes menu. Here, you can access all your hashing history.";
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
            helpLabel.Text = "You selected this file: " + safeSelectedFileName + " Now, you can hash or encrypt it.";

        }

        private void openFolderDialog_menuItem_click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog(this);
            selectedFileName = folderBrowserDialog1.SelectedPath;
            label1.Text = "Selected Folder: " + selectedFileName;
            helpLabel.Text = "You have selected this folder: " + selectedFileName + " When you operate with this folder, the operation will be applied to all files in the folder. ";

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
                helpLabel.Text = "You have hashed: " + safeSelectedFileName + " with " + hashComboBox.Text + " algorithm!";
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

                    MessageBox.Show("Sucessfull!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    helpLabel.Text = "You saved all logs to " + saveFileDialog1.FileName + "\n";
                }
                catch (Exception ex) //burda niye exception var???????????
                {// he tamam zorunluymus
                    MessageBox.Show("Error: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hashAll_click(object sender, EventArgs e)
        {
            hashingClass hash = new hashingClass();
            if (System.IO.File.Exists(selectedFileName))
            {
                richTextBox1.Text += hash.hashAll(selectedFileName, safeSelectedFileName);
                helpLabel.Text = "The operation has been completed with all hashing types for " + safeSelectedFileName + ".";

            }
            else if (System.IO.Directory.Exists(selectedFileName))
            {
                string[] fileEntries = System.IO.Directory.GetFiles(selectedFileName);
                foreach (string fileName in fileEntries)
                    richTextBox1.Text += hash.hashAll(fileName, fileName);
                helpLabel.Text = "The operation has been performed with all hashing types for all files in the folder.";

            }

        }

        private void clear_menuItem_click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            helpLabel.Text = "All logs are cleared.";
        }

        private void textHash_menuItem_click(object sender, EventArgs e)
        {
            helpLabel.Text = "You've opened the Text Hashing menu. Here, you can hash all texts.";
            Form TextHashing = new TextHashing();
            TextHashing.ShowDialog(this);
        }

        private void generateRSAPair_click(object sender, EventArgs e)
        {
            helpLabel.Text = "Now, you are generating encryption pairs for RSA encryption. These pairs consist of two keys: the Public key, used for encryption, and the Private key, used for decryption.";
            string keySize = keySizeValue.Text;
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
                if (storageCheckbox.Checked)
                {
                    rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
                    csvManager2.checkdbFile();
                    csvManager2.WriteToCsv("Public", Path.GetFileName(savePublicDialog.FileName), savePublicDialog.FileName, DateTime.Now);

                }
            }
            SaveFileDialog savePrivateDialog = new SaveFileDialog();
            savePrivateDialog.Filter = "C# RSA Private Key (*.xml)|*.xml|All Files (*.*)|*.*";
            if (savePrivateDialog.ShowDialog() == DialogResult.OK)
            {
                string privateKeyPath = savePrivateDialog.FileName;
                StreamWriter Kayit = new StreamWriter(savePrivateDialog.FileName);
                Kayit.WriteLine(buffer2);
                Kayit.Close();
                if (storageCheckbox.Checked)
                {
                    rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
                    csvManager2.checkdbFile();
                    csvManager2.WriteToCsv("Private", Path.GetFileName(savePrivateDialog.FileName), savePrivateDialog.FileName, DateTime.Now);

                }
            }
        }



        private void openPublicKey_click(object sender, EventArgs e)
        {
            rsaPublicKeyOpenFileDialog.Title = "Dosya Seç";
            rsaPublicKeyOpenFileDialog.Filter = "C# Public Key (*.xml)|*.xml|All Files (*.*)|*.*";
            rsaPublicKeyOpenFileDialog.RestoreDirectory = true;
            result = rsaPublicKeyOpenFileDialog.ShowDialog(this);
            safePublicKeySelectedFileName = rsaPublicKeyOpenFileDialog.SafeFileName;
            PublicKeyselectedFileName = rsaPublicKeyOpenFileDialog.FileName;
            publicKeyLabel.Text = "Selected File: " + safePublicKeySelectedFileName;
        }

        private void openPrivateKey_click(object sender, EventArgs e)
        {
            rsaPrivateKeyOpenFileDialog.Title = "Dosya Seç";
            rsaPrivateKeyOpenFileDialog.Filter = "C# Private Key (*.xml)|*.xml|All Files (*.*)|*.*";
            rsaPrivateKeyOpenFileDialog.RestoreDirectory = true;
            result2 = rsaPrivateKeyOpenFileDialog.ShowDialog(this);
            safePrivateKeySelectedFileName = rsaPrivateKeyOpenFileDialog.SafeFileName;
            PrivateKeyselectedFileName = rsaPrivateKeyOpenFileDialog.FileName;
            privateKeyLabel.Text = "Selected File: " + safePrivateKeySelectedFileName;
        }

        private void encrypt_click(object sender, EventArgs e)
        {
            if (result != DialogResult.OK)
            {
                MessageBox.Show("You Should Select a Public Key for Encryption!");
            }
            else
            {
                if (System.IO.File.Exists(selectedFileName))
                {
                    byte[] fileData = File.ReadAllBytes(selectedFileName);
                    string publicKeyText = File.ReadAllText(PublicKeyselectedFileName);
                    using (RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider())
                    {
                        RSAalg.PersistKeyInCsp = false;
                        RSAalg.FromXmlString(publicKeyText);
                        try
                        {
                            Byte[] encryptedData = RSAalg.Encrypt(fileData, true);
                            SaveFileDialog saveEncryptedDialog = new SaveFileDialog();
                            saveEncryptedDialog.Filter = "All Files (*.*)|*.*";
                            if (saveEncryptedDialog.ShowDialog() == DialogResult.OK)
                            {
                                string encryptedFilePath = saveEncryptedDialog.FileName;
                                File.WriteAllBytes(encryptedFilePath, encryptedData);
                                MessageBox.Show("Success!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Encryption of the file failed! File size limit depends on your key size.");
                        }

                    }
                }
                else if (System.IO.Directory.Exists(selectedFileName))
                {
                    string[] fileEntries = System.IO.Directory.GetFiles(selectedFileName);
                    foreach (string fileName in fileEntries)
                    {
                        byte[] fileData = File.ReadAllBytes(fileName);
                        string publicKeyText = File.ReadAllText(PublicKeyselectedFileName);
                        using (RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider())
                        {
                            RSAalg.PersistKeyInCsp = false;
                            RSAalg.FromXmlString(publicKeyText);
                            try
                            {
                                Byte[] encryptedData = RSAalg.Encrypt(fileData, true);
                                string encryptedFilePath = fileName + ".enc";
                                File.WriteAllBytes(encryptedFilePath, encryptedData);
                                MessageBox.Show("Successfully encrypted: " + encryptedFilePath);
                            }
                            catch
                            {
                                MessageBox.Show("Encryption of this file failed: " + fileName);
                            }

                        }
                    }
                }
            }
        }

        private void decrypt_click(object sender, EventArgs e)
        {
            if (result2 != DialogResult.OK)
            {
                MessageBox.Show("You Should Select a Private Key for Decryption!");
            }
            else
            {
                if (System.IO.File.Exists(selectedFileName))
                {
                    byte[] fileData = File.ReadAllBytes(selectedFileName);
                    string privateKeyText = File.ReadAllText(PrivateKeyselectedFileName);
                    using (RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider())
                    {
                        RSAalg.PersistKeyInCsp = false;
                        RSAalg.FromXmlString(privateKeyText);
                        try
                        {
                            Byte[] encryptedData = RSAalg.Decrypt(fileData, true);
                            SaveFileDialog saveEncryptedDialog = new SaveFileDialog();
                            saveEncryptedDialog.Filter = "All Files (*.*)|*.*";
                            if (saveEncryptedDialog.ShowDialog() == DialogResult.OK)
                            {
                                string encryptedFilePath = saveEncryptedDialog.FileName;
                                File.WriteAllBytes(encryptedFilePath, encryptedData);
                                MessageBox.Show("Success!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Decryption of the file failed! Check your private key.");
                        }

                    }
                }
                else if (System.IO.Directory.Exists(selectedFileName))
                {
                    string[] fileEntries = System.IO.Directory.GetFiles(selectedFileName);
                    string privateKeyText = File.ReadAllText(PrivateKeyselectedFileName);
                    int k = 0;
                    foreach (string fileName in fileEntries)
                    {
                        if (fileName.EndsWith(".enc"))
                        {
                            k++;
                            byte[] fileData = File.ReadAllBytes(fileName);
                            using (RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider())
                            {
                                RSAalg.FromXmlString(privateKeyText);
                                try
                                {
                                    Byte[] encryptedData = RSAalg.Decrypt(fileData, true);
                                    string encryptedFilePath = fileName + ".decrypted";
                                    File.WriteAllBytes(encryptedFilePath, encryptedData);
                                    MessageBox.Show("Successfully decrypted: " + encryptedFilePath);
                                }
                                catch
                                {
                                    MessageBox.Show("Decryption of this file failed: " + fileName);
                                }
                            }
                        }

                    }
                    if (k == 0)
                    {
                        MessageBox.Show("There is no file for decryption! Check your '.enc' files.");
                    }
                }
            }
        }

        private void storageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            helpLabel.Text = "Now that you have checked the 'Save Storage' checkbox, when you generate a new RSA pair, DreamLock will save it in your RSA Storage";
        }
    }

}
