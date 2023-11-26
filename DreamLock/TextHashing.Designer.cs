namespace DreamLock
{
    partial class TextHashing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextHashing));
            hashComboBox = new ComboBox();
            hashInput = new TextBox();
            button1 = new Button();
            hashTextResult1 = new TextBox();
            SuspendLayout();
            // 
            // hashComboBox
            // 
            hashComboBox.BackColor = Color.WhiteSmoke;
            hashComboBox.FormattingEnabled = true;
            hashComboBox.Items.AddRange(new object[] { "MD2", "MD4", "MD5", "SHA-1", "SHA-224", "SHA-256", "SHA-384", "SHA-512", "Whirlpool", "RIPEMD128", "RIPEMD160", "RIPEMD256", "RIPEMD320" });
            hashComboBox.Location = new Point(12, 40);
            hashComboBox.Margin = new Padding(3, 2, 3, 2);
            hashComboBox.Name = "hashComboBox";
            hashComboBox.Size = new Size(585, 23);
            hashComboBox.TabIndex = 4;
            hashComboBox.Text = "MD5";
            // 
            // hashInput
            // 
            hashInput.Location = new Point(12, 12);
            hashInput.Name = "hashInput";
            hashInput.Size = new Size(585, 23);
            hashInput.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(258, 68);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 6;
            button1.Text = "Hash It!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hashTextResult1
            // 
            hashTextResult1.BorderStyle = BorderStyle.None;
            hashTextResult1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            hashTextResult1.Location = new Point(12, 118);
            hashTextResult1.Multiline = true;
            hashTextResult1.Name = "hashTextResult1";
            hashTextResult1.ReadOnly = true;
            hashTextResult1.Size = new Size(585, 134);
            hashTextResult1.TabIndex = 8;
            hashTextResult1.TabStop = false;
            hashTextResult1.Text = "Result:\r\n\r\nHash Type:\r\n\r\n";
            // 
            // TextHashing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 253);
            Controls.Add(hashTextResult1);
            Controls.Add(button1);
            Controls.Add(hashInput);
            Controls.Add(hashComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TextHashing";
            Text = "DreamLock Text Hashing";
            Load += TextHashing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox hashComboBox;
        private TextBox hashInput;
        private Button button1;
        private TextBox hashTextResult1;
    }
}