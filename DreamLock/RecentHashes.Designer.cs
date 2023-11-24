namespace DreamLock
{
    partial class RecentHashes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecentHashes));
            listBox1 = new ListBox();
            fileNameLabel = new Label();
            hashTypeLabel = new Label();
            hashValueLabel = new Label();
            hashDateLabel = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(348, 229);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fileNameLabel.Location = new Point(366, 12);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(91, 18);
            fileNameLabel.TabIndex = 2;
            fileNameLabel.Text = "File Name:";
            fileNameLabel.Click += label1_Click;
            // 
            // hashTypeLabel
            // 
            hashTypeLabel.AutoSize = true;
            hashTypeLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hashTypeLabel.Location = new Point(366, 48);
            hashTypeLabel.Name = "hashTypeLabel";
            hashTypeLabel.Size = new Size(97, 18);
            hashTypeLabel.TabIndex = 3;
            hashTypeLabel.Text = "Hash Type:";
            // 
            // hashValueLabel
            // 
            hashValueLabel.AutoSize = true;
            hashValueLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hashValueLabel.Location = new Point(366, 84);
            hashValueLabel.Name = "hashValueLabel";
            hashValueLabel.Size = new Size(103, 18);
            hashValueLabel.TabIndex = 4;
            hashValueLabel.Text = "Hash Value:";
            // 
            // hashDateLabel
            // 
            hashDateLabel.AutoSize = true;
            hashDateLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hashDateLabel.Location = new Point(366, 120);
            hashDateLabel.Name = "hashDateLabel";
            hashDateLabel.Size = new Size(96, 18);
            hashDateLabel.TabIndex = 5;
            hashDateLabel.Text = "Hash Date:";
            // 
            // RecentHashes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 253);
            Controls.Add(hashDateLabel);
            Controls.Add(hashValueLabel);
            Controls.Add(hashTypeLabel);
            Controls.Add(fileNameLabel);
            Controls.Add(listBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RecentHashes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DreamLock Recent Hashes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Label fileNameLabel;
        private Label hashTypeLabel;
        private Label hashValueLabel;
        private Label hashDateLabel;
    }
}