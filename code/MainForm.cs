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

        public enum EncryptionType
        {
            AES,
            RSA,
            TripleDES,
            Blowfish,
            Twofish
        }

        private void hideEncryptionKeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            encryptionKeyTextbox.UseSystemPasswordChar = checkBox.Checked;
        }

        private void GenerateRandomKeyButton_Click(object sender, EventArgs e)
        {
            Encryptor E = null;
            
            
           //AES
           if(encryptionMethodComboBox.SelectedIndex == 0)
            {
                if (RandomKeyCheckBox.Checked)
                {
                    E = new AES();
                }
                else
                {
                    E = new AES(encryptionKeyTextbox.Text);
                }
                E.Start(encryptRadioButton.Checked);

                while (!E.complete)
                {
                    EncryptButton.Enabled = false;
                }

                //when e.complete = true
                E.Stop();
                E.Output(ref ciphertextTextbox);
                
            }
           //RSA
           if(encryptionMethodComboBox.SelectedIndex == 1)
            {
                MessageBox.Show("Being developed soon!");
            }
           //TripleDes
           if(encryptionMethodComboBox.SelectedIndex == 2)
            {
                MessageBox.Show("Being developed soon!");
            }
           //Blowfish
           if(encryptionMethodComboBox.SelectedIndex == 3)
            {
                MessageBox.Show("Being developed soon!");
            }
           //TwoFish
           if(encryptionMethodComboBox.SelectedIndex == 4)
            {
                MessageBox.Show("Being developed soon!");
            }

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
