namespace DreamLock
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            saveResultsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            araçlarToolStripMenuItem = new ToolStripMenuItem();
            RecentHashesMenuItem = new ToolStripMenuItem();
            RecentHashesVirusTotalMenuItem = new ToolStripMenuItem();
            RSAKeyDeposuMenuItem = new ToolStripMenuItem();
            AESKeyDeposuMenuItem = new ToolStripMenuItem();
            switchToOldAlgorithmsMenuItem = new ToolStripMenuItem();
            textHashingToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            hashComboBox = new ComboBox();
            button2 = new Button();
            hashItButton = new Button();
            label3 = new Label();
            button7 = new Button();
            label8 = new Label();
            button9 = new Button();
            label9 = new Label();
            button5 = new Button();
            label6 = new Label();
            button4 = new Button();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label4 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.SelectedPath = " ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, araçlarToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(975, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, açToolStripMenuItem, toolStripSeparator, toolStripSeparator1, toolStripSeparator2, saveResultsToolStripMenuItem, clearToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(37, 20);
            dosyaToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuItem2.Size = new Size(179, 22);
            toolStripMenuItem2.Text = "&Open File";
            toolStripMenuItem2.Click += openFileDialog_menuItem_click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Image = (Image)resources.GetObject("açToolStripMenuItem.Image");
            açToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            açToolStripMenuItem.Size = new Size(179, 22);
            açToolStripMenuItem.Text = "&Open Folder";
            açToolStripMenuItem.Click += openFolderDialog_menuItem_click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(176, 6);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(176, 6);
            // 
            // saveResultsToolStripMenuItem
            // 
            saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            saveResultsToolStripMenuItem.Size = new Size(179, 22);
            saveResultsToolStripMenuItem.Text = "Save Results";
            saveResultsToolStripMenuItem.Click += saveResults_menuItem_click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(179, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clear_menuItem_click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(179, 22);
            çıkışToolStripMenuItem.Text = "Exit";
            çıkışToolStripMenuItem.Click += exit_menuItem_click;
            // 
            // araçlarToolStripMenuItem
            // 
            araçlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RecentHashesMenuItem, RecentHashesVirusTotalMenuItem, RSAKeyDeposuMenuItem, AESKeyDeposuMenuItem, switchToOldAlgorithmsMenuItem, textHashingToolStripMenuItem });
            araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            araçlarToolStripMenuItem.Size = new Size(46, 20);
            araçlarToolStripMenuItem.Text = "&Tools";
            // 
            // RecentHashesMenuItem
            // 
            RecentHashesMenuItem.Name = "RecentHashesMenuItem";
            RecentHashesMenuItem.Size = new Size(260, 22);
            RecentHashesMenuItem.Text = "&Recent Hashes";
            RecentHashesMenuItem.Click += RecentHashes_menuItem_click;
            // 
            // RecentHashesVirusTotalMenuItem
            // 
            RecentHashesVirusTotalMenuItem.Name = "RecentHashesVirusTotalMenuItem";
            RecentHashesVirusTotalMenuItem.Size = new Size(260, 22);
            RecentHashesVirusTotalMenuItem.Text = "Search Recent Hashes on VirusTotal";
            RecentHashesVirusTotalMenuItem.Click += virusTotalRecentHashes_menuItem_click;
            // 
            // RSAKeyDeposuMenuItem
            // 
            RSAKeyDeposuMenuItem.Name = "RSAKeyDeposuMenuItem";
            RSAKeyDeposuMenuItem.Size = new Size(260, 22);
            RSAKeyDeposuMenuItem.Text = "RSA Key Storage";
            RSAKeyDeposuMenuItem.Click += RSAKeyStorage_menuItem_click;
            // 
            // AESKeyDeposuMenuItem
            // 
            AESKeyDeposuMenuItem.Name = "AESKeyDeposuMenuItem";
            AESKeyDeposuMenuItem.Size = new Size(260, 22);
            AESKeyDeposuMenuItem.Text = "AES Key Storage";
            AESKeyDeposuMenuItem.Click += AESKeyStorage_menuItem_click;
            // 
            // switchToOldAlgorithmsMenuItem
            // 
            switchToOldAlgorithmsMenuItem.Name = "switchToOldAlgorithmsMenuItem";
            switchToOldAlgorithmsMenuItem.Size = new Size(260, 22);
            switchToOldAlgorithmsMenuItem.Text = "Switch to Old Algorithms";
            switchToOldAlgorithmsMenuItem.Click += switchToOldAlgorithms_menuItem_click;
            // 
            // textHashingToolStripMenuItem
            // 
            textHashingToolStripMenuItem.Name = "textHashingToolStripMenuItem";
            textHashingToolStripMenuItem.Size = new Size(260, 22);
            textHashingToolStripMenuItem.Text = "Text Hashing";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkındaToolStripMenuItem, toolStripSeparator5 });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(56, 20);
            yardımToolStripMenuItem.Text = "&Special";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(107, 22);
            hakkındaToolStripMenuItem.Text = "&About";
            hakkındaToolStripMenuItem.Click += aboutMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(104, 6);
            // 
            // splitContainer1
            // 
            splitContainer1.AllowDrop = true;
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 26);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            splitContainer1.Panel1MinSize = 1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2MinSize = 1;
            splitContainer1.Size = new Size(975, 449);
            splitContainer1.SplitterDistance = 52;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(973, 50);
            label1.TabIndex = 0;
            label1.Text = "No file selected yet!\r\nYou can select your file on \"File\" tab.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(richTextBox1);
            splitContainer2.Panel1.Controls.Add(hashComboBox);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(hashItButton);
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button7);
            splitContainer2.Panel2.Controls.Add(label8);
            splitContainer2.Panel2.Controls.Add(button9);
            splitContainer2.Panel2.Controls.Add(label9);
            splitContainer2.Panel2.Controls.Add(button5);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Panel2.Controls.Add(button4);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Panel2.Controls.Add(comboBox2);
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Size = new Size(975, 395);
            splitContainer2.SplitterDistance = 397;
            splitContainer2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 184);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(389, 207);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // hashComboBox
            // 
            hashComboBox.BackColor = Color.WhiteSmoke;
            hashComboBox.Dock = DockStyle.Fill;
            hashComboBox.FormattingEnabled = true;
            hashComboBox.Items.AddRange(new object[] { "MD2", "MD4", "MD5", "SHA-1", "SHA-224", "SHA-256", "SHA-384", "SHA-512", "Whirlpool", "RIPEMD128", "RIPEMD160", "RIPEMD256", "RIPEMD320" });
            hashComboBox.Location = new Point(0, 48);
            hashComboBox.Margin = new Padding(3, 2, 3, 2);
            hashComboBox.Name = "hashComboBox";
            hashComboBox.Size = new Size(395, 23);
            hashComboBox.TabIndex = 3;
            hashComboBox.Text = "MD5";
            // 
            // button2
            // 
            button2.Location = new Point(3, 140);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(389, 34);
            button2.TabIndex = 2;
            button2.Text = "Generate All Hashes!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += hashAll_click;
            // 
            // hashItButton
            // 
            hashItButton.Location = new Point(3, 90);
            hashItButton.Margin = new Padding(3, 2, 3, 2);
            hashItButton.Name = "hashItButton";
            hashItButton.Size = new Size(389, 36);
            hashItButton.TabIndex = 1;
            hashItButton.Text = "Hash It!";
            hashItButton.UseVisualStyleBackColor = true;
            hashItButton.Click += hashItButton_click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(395, 48);
            label3.TabIndex = 0;
            label3.Text = "HASH IT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.Location = new Point(3, 356);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(566, 35);
            button7.TabIndex = 18;
            button7.Text = "Decrypt and Save!";
            button7.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 314);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 17;
            label8.Text = "Nothing Selected";
            // 
            // button9
            // 
            button9.Location = new Point(3, 307);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(219, 28);
            button9.TabIndex = 16;
            button9.Text = "Select Private Key!";
            button9.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(238, 268);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 15;
            label9.Text = "Decrypt!";
            // 
            // button5
            // 
            button5.Location = new Point(3, 220);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(566, 35);
            button5.TabIndex = 7;
            button5.Text = "Encrypt and Save!";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 181);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 6;
            label6.Text = "Nothing Selected";
            // 
            // button4
            // 
            button4.Location = new Point(3, 174);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(219, 28);
            button4.TabIndex = 5;
            button4.Text = "Select Public Key!";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(240, 140);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 4;
            label5.Text = "Encrypt!";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.BackColor = Color.WhiteSmoke;
            comboBox2.Dock = DockStyle.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "RSA", "AES", "DES" });
            comboBox2.Location = new Point(0, 48);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(572, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "RSA";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(3, 75);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(584, 85);
            button3.TabIndex = 2;
            button3.Text = "Generate Pair! (Public - Private)";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(572, 48);
            label4.TabIndex = 1;
            label4.Text = "ENCRYPT - DECRYPT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(975, 476);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DreamLock";
            Load += Panel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem araçlarToolStripMenuItem;
        private ToolStripMenuItem RecentHashesMenuItem;
        private ToolStripMenuItem RecentHashesVirusTotalMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem RSAKeyDeposuMenuItem;
        private ToolStripMenuItem AESKeyDeposuMenuItem;
        private ToolStripMenuItem switchToOldAlgorithmsMenuItem;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private ComboBox hashComboBox;
        private Button button2;
        private Button hashItButton;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button4;
        private Label label5;
        private ComboBox comboBox2;
        private Button button3;
        private Button button5;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Label label9;
        private Button button7;
        private Label label8;
        private Button button9;
        private ToolStripMenuItem saveResultsToolStripMenuItem;
        private ToolStripMenuItem textHashingToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}