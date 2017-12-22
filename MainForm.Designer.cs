using System.Windows.Forms;

namespace EncryptionHeckingCode
{
    partial class EncryptionMainForm
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
            this.encryptionMethodComboBox = new EncryptionHeckingCode.AdvancedComboBox();
            this.encryptionMethodLabel = new System.Windows.Forms.Label();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaintextTextbox = new System.Windows.Forms.RichTextBox();
            this.plaintextTextboxLabel = new System.Windows.Forms.Label();
            this.encryptionKeyTextbox = new System.Windows.Forms.TextBox();
            this.encryptionKeyLabel = new System.Windows.Forms.Label();
            this.GenerateRandomKeyButton = new System.Windows.Forms.Button();
            this.hideEncryptionKeyCheckbox = new System.Windows.Forms.CheckBox();
            this.ciphertextLabel = new System.Windows.Forms.Label();
            this.ciphertextTextbox = new System.Windows.Forms.RichTextBox();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaintextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciphertextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaintextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ciphertextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptionMethodComboBox
            // 
            this.encryptionMethodComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.encryptionMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptionMethodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptionMethodComboBox.FormattingEnabled = true;
            this.encryptionMethodComboBox.HighlightColor = System.Drawing.Color.Silver;
            this.encryptionMethodComboBox.Items.AddRange(new object[] {
            "RSA",
            "Triple DES",
            "Blowfish",
            "AES",
            "Twofish"});
            this.encryptionMethodComboBox.Location = new System.Drawing.Point(166, 30);
            this.encryptionMethodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.encryptionMethodComboBox.Name = "encryptionMethodComboBox";
            this.encryptionMethodComboBox.Size = new System.Drawing.Size(287, 28);
            this.encryptionMethodComboBox.TabIndex = 0;
            this.encryptionMethodComboBox.DropDown += new System.EventHandler(this.encryptionMethodComboBox_DropDown);
            // 
            // encryptionMethodLabel
            // 
            this.encryptionMethodLabel.AutoSize = true;
            this.encryptionMethodLabel.Location = new System.Drawing.Point(12, 33);
            this.encryptionMethodLabel.Name = "encryptionMethodLabel";
            this.encryptionMethodLabel.Size = new System.Drawing.Size(147, 19);
            this.encryptionMethodLabel.TabIndex = 1;
            this.encryptionMethodLabel.Text = "Encryption Method:";
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(879, 24);
            this.mainFormMenuStrip.TabIndex = 2;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load from file...";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file...";
            // 
            // plaintextTextbox
            // 
            this.plaintextTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plaintextTextbox.Location = new System.Drawing.Point(12, 164);
            this.plaintextTextbox.Name = "plaintextTextbox";
            this.plaintextTextbox.Size = new System.Drawing.Size(441, 302);
            this.plaintextTextbox.TabIndex = 3;
            this.plaintextTextbox.Text = "";
            this.plaintextTextbox.TextChanged += new System.EventHandler(this.CheckToEnableEncryptButton);
            // 
            // plaintextTextboxLabel
            // 
            this.plaintextTextboxLabel.AutoSize = true;
            this.plaintextTextboxLabel.Location = new System.Drawing.Point(12, 137);
            this.plaintextTextboxLabel.Name = "plaintextTextboxLabel";
            this.plaintextTextboxLabel.Size = new System.Drawing.Size(69, 19);
            this.plaintextTextboxLabel.TabIndex = 4;
            this.plaintextTextboxLabel.Text = "Plaintext";
            // 
            // encryptionKeyTextbox
            // 
            this.encryptionKeyTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptionKeyTextbox.Location = new System.Drawing.Point(16, 102);
            this.encryptionKeyTextbox.Name = "encryptionKeyTextbox";
            this.encryptionKeyTextbox.Size = new System.Drawing.Size(437, 27);
            this.encryptionKeyTextbox.TabIndex = 5;
            this.encryptionKeyTextbox.TextChanged += new System.EventHandler(this.CheckToEnableEncryptButton);
            // 
            // encryptionKeyLabel
            // 
            this.encryptionKeyLabel.AutoSize = true;
            this.encryptionKeyLabel.Location = new System.Drawing.Point(12, 69);
            this.encryptionKeyLabel.Name = "encryptionKeyLabel";
            this.encryptionKeyLabel.Size = new System.Drawing.Size(114, 19);
            this.encryptionKeyLabel.TabIndex = 6;
            this.encryptionKeyLabel.Text = "Encryption Key";
            // 
            // GenerateRandomKeyButton
            // 
            this.GenerateRandomKeyButton.Location = new System.Drawing.Point(141, 65);
            this.GenerateRandomKeyButton.Name = "GenerateRandomKeyButton";
            this.GenerateRandomKeyButton.Size = new System.Drawing.Size(104, 28);
            this.GenerateRandomKeyButton.TabIndex = 7;
            this.GenerateRandomKeyButton.Text = "Random";
            this.GenerateRandomKeyButton.UseVisualStyleBackColor = true;
            this.GenerateRandomKeyButton.Click += new System.EventHandler(this.GenerateRandomKeyButton_Click);
            // 
            // hideEncryptionKeyCheckbox
            // 
            this.hideEncryptionKeyCheckbox.AutoSize = true;
            this.hideEncryptionKeyCheckbox.Location = new System.Drawing.Point(251, 68);
            this.hideEncryptionKeyCheckbox.Name = "hideEncryptionKeyCheckbox";
            this.hideEncryptionKeyCheckbox.Size = new System.Drawing.Size(90, 23);
            this.hideEncryptionKeyCheckbox.TabIndex = 8;
            this.hideEncryptionKeyCheckbox.Text = "Hide Key";
            this.hideEncryptionKeyCheckbox.UseVisualStyleBackColor = true;
            this.hideEncryptionKeyCheckbox.CheckedChanged += new System.EventHandler(this.hideEncryptionKeyCheckbox_CheckedChanged);
            // 
            // ciphertextLabel
            // 
            this.ciphertextLabel.AutoSize = true;
            this.ciphertextLabel.Location = new System.Drawing.Point(469, 30);
            this.ciphertextLabel.Name = "ciphertextLabel";
            this.ciphertextLabel.Size = new System.Drawing.Size(81, 19);
            this.ciphertextLabel.TabIndex = 9;
            this.ciphertextLabel.Text = "Ciphertext";
            // 
            // ciphertextTextbox
            // 
            this.ciphertextTextbox.BackColor = System.Drawing.Color.White;
            this.ciphertextTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ciphertextTextbox.Location = new System.Drawing.Point(473, 67);
            this.ciphertextTextbox.Name = "ciphertextTextbox";
            this.ciphertextTextbox.Size = new System.Drawing.Size(394, 399);
            this.ciphertextTextbox.TabIndex = 10;
            this.ciphertextTextbox.Text = "";
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(373, 483);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.encryptRadioButton.Size = new System.Drawing.Size(80, 23);
            this.encryptRadioButton.TabIndex = 11;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Encrypt";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Location = new System.Drawing.Point(473, 483);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decryptRadioButton.Size = new System.Drawing.Size(81, 23);
            this.decryptRadioButton.TabIndex = 12;
            this.decryptRadioButton.TabStop = true;
            this.decryptRadioButton.Text = "Decrypt";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plaintextToolStripMenuItem,
            this.ciphertextToolStripMenuItem,
            this.encryptionKeyToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // plaintextToolStripMenuItem
            // 
            this.plaintextToolStripMenuItem.Name = "plaintextToolStripMenuItem";
            this.plaintextToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.plaintextToolStripMenuItem.Text = "Plaintext";
            // 
            // ciphertextToolStripMenuItem
            // 
            this.ciphertextToolStripMenuItem.Name = "ciphertextToolStripMenuItem";
            this.ciphertextToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ciphertextToolStripMenuItem.Text = "Ciphertext";
            // 
            // encryptionKeyToolStripMenuItem
            // 
            this.encryptionKeyToolStripMenuItem.Name = "encryptionKeyToolStripMenuItem";
            this.encryptionKeyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.encryptionKeyToolStripMenuItem.Text = "Encryption Key";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plaintextToolStripMenuItem1,
            this.ciphertextToolStripMenuItem1,
            this.encryptionKeyToolStripMenuItem1});
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // plaintextToolStripMenuItem1
            // 
            this.plaintextToolStripMenuItem1.Name = "plaintextToolStripMenuItem1";
            this.plaintextToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.plaintextToolStripMenuItem1.Text = "Plaintext";
            // 
            // ciphertextToolStripMenuItem1
            // 
            this.ciphertextToolStripMenuItem1.Name = "ciphertextToolStripMenuItem1";
            this.ciphertextToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.ciphertextToolStripMenuItem1.Text = "Ciphertext";
            // 
            // encryptionKeyToolStripMenuItem1
            // 
            this.encryptionKeyToolStripMenuItem1.Name = "encryptionKeyToolStripMenuItem1";
            this.encryptionKeyToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.encryptionKeyToolStripMenuItem1.Text = "Encryption Key";
            // 
            // EncryptionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(879, 518);
            this.Controls.Add(this.decryptRadioButton);
            this.Controls.Add(this.encryptRadioButton);
            this.Controls.Add(this.ciphertextTextbox);
            this.Controls.Add(this.ciphertextLabel);
            this.Controls.Add(this.hideEncryptionKeyCheckbox);
            this.Controls.Add(this.GenerateRandomKeyButton);
            this.Controls.Add(this.encryptionKeyLabel);
            this.Controls.Add(this.encryptionKeyTextbox);
            this.Controls.Add(this.plaintextTextboxLabel);
            this.Controls.Add(this.plaintextTextbox);
            this.Controls.Add(this.encryptionMethodLabel);
            this.Controls.Add(this.encryptionMethodComboBox);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncryptionMainForm";
            this.Text = "Hecking Code Encryption";
            this.Load += new System.EventHandler(this.EncryptionMainForm_Load);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label encryptionMethodLabel;
        private AdvancedComboBox encryptionMethodComboBox;
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox plaintextTextbox;
        private System.Windows.Forms.Label plaintextTextboxLabel;
        private System.Windows.Forms.TextBox encryptionKeyTextbox;
        private System.Windows.Forms.Label encryptionKeyLabel;
        private System.Windows.Forms.Button GenerateRandomKeyButton;
        private System.Windows.Forms.CheckBox hideEncryptionKeyCheckbox;
        private System.Windows.Forms.Label ciphertextLabel;
        private System.Windows.Forms.RichTextBox ciphertextTextbox;
        private RadioButton encryptRadioButton;
        private RadioButton decryptRadioButton;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem plaintextToolStripMenuItem;
        private ToolStripMenuItem ciphertextToolStripMenuItem;
        private ToolStripMenuItem encryptionKeyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem plaintextToolStripMenuItem1;
        private ToolStripMenuItem ciphertextToolStripMenuItem1;
        private ToolStripMenuItem encryptionKeyToolStripMenuItem1;
    }
}

