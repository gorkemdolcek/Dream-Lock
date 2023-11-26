namespace DreamLock
{
    partial class RSAKeyStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSAKeyStorage));
            keyList = new ListView();
            keyTypeHeader = new ColumnHeader();
            keyNameHeader = new ColumnHeader();
            keySavedLocationHeader = new ColumnHeader();
            keyCreationDate = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // keyList
            // 
            keyList.Columns.AddRange(new ColumnHeader[] { keyTypeHeader, keyNameHeader, keySavedLocationHeader, keyCreationDate });
            keyList.Location = new Point(12, 12);
            keyList.Name = "keyList";
            keyList.Size = new Size(653, 260);
            keyList.TabIndex = 0;
            keyList.UseCompatibleStateImageBehavior = false;
            keyList.View = View.Details;
            keyList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // keyTypeHeader
            // 
            keyTypeHeader.Text = "Key Type";
            keyTypeHeader.Width = 80;
            // 
            // keyNameHeader
            // 
            keyNameHeader.Text = "Key Name";
            keyNameHeader.Width = 150;
            // 
            // keySavedLocationHeader
            // 
            keySavedLocationHeader.Text = "Key Saved Location";
            keySavedLocationHeader.Width = 300;
            // 
            // keyCreationDate
            // 
            keyCreationDate.Text = "Creation Date";
            keyCreationDate.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(177, 278);
            button1.Name = "button1";
            button1.Size = new Size(158, 45);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += deletePairFromRSAStorage_click;
            // 
            // button2
            // 
            button2.Location = new Point(505, 278);
            button2.Name = "button2";
            button2.Size = new Size(158, 45);
            button2.TabIndex = 2;
            button2.Text = "Open Key Location";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(341, 278);
            button3.Name = "button3";
            button3.Size = new Size(158, 45);
            button3.TabIndex = 3;
            button3.Text = "Export Key to New Location";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 278);
            button4.Name = "button4";
            button4.Size = new Size(158, 45);
            button4.TabIndex = 4;
            button4.Text = "Add New Pair";
            button4.UseVisualStyleBackColor = true;
            button4.Click += addNewKeypair_click;
            // 
            // RSAKeyStorage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 331);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(keyList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RSAKeyStorage";
            Text = "DreamLock RSA Key Storage";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader keyTypeHeader;
        private ColumnHeader keyNameHeader;
        private ColumnHeader keySavedLocationHeader;
        private ColumnHeader keyCreationDate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView keyList;
    }
}