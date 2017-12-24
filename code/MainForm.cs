using System;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptionHeckingCode
{
    public partial class EncryptionMainForm : Form
    {
        public EncryptionMainForm()
        {
            InitializeComponent();
        }
        //
        private void hideEncryptionKeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            encryptionKeyTextbox.UseSystemPasswordChar = checkBox.Checked;
        }

        private void GenerateRandomKeyButton_Click(object sender, EventArgs e)
        {
            //
          //  encryptionKeyTextbox.Text = KeyGenerator.NewKey(128);
        }
        
        private void CheckToEnableEncryptButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(plaintextTextbox.Text) &&
                encryptionKeyTextbox.Text != "")
            {
                encryptRadioButton.Enabled = true;
                decryptRadioButton.Enabled = true;
            }
            else
            {
                encryptRadioButton.Enabled = false;
                decryptRadioButton.Enabled = false;
            }
        }

        private void EncryptionMainForm_Load(object sender, EventArgs e)
        {
            encryptionMethodComboBox.HighlightColor = Color.White;
            encryptionMethodComboBox.SelectedIndex = 0;
        }

        private void encryptionMethodComboBox_DropDown(object sender, EventArgs e)
        {
            encryptionMethodComboBox.HighlightColor = Color.Gainsboro;
        }
    }
}
