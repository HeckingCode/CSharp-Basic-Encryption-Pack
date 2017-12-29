using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptionHeckingCode
{
    public partial class EncryptionMainForm : Form
    {
        private readonly List<Encryptor> encryptorList = new List<Encryptor>();

        public EncryptionMainForm()
        {
            InitializeComponent();
        }

        private void StopAllEncryptors()
        {
            foreach (Encryptor encryptor in encryptorList)
            {
                encryptor.Stop();
                encryptorList.Remove(encryptor);
            }
        }

        private void InstantiateAESEncryptor(ref Encryptor encryptor)
        {
            if (randomKeyCheckBox.Checked)
            {
                //start with random generated key
                encryptor = new AES();
            }
            else
            {
                //start with user input key
                if (AES.IsValidKey(encryptionKeyTextbox.Text))
                    encryptor = new AES(encryptionKeyTextbox.Text);
                else
                    MessageBox.Show("Key length must be greater than 128 and a multiple of 32");
            }
        }

        public void StartAESOperation(ref Encryptor encryptor)
        {
            //if encrypt radio ticked to determine if encryption or decryption
            //E.Start(encryptRadioButton.Checked);
            encryptor.Start(encryptRadioButton.Checked);
            encryptButton.Text = "Stop";
            encryptorList.Add(encryptor);

            while (!encryptor.IsComplete)
            {
                //wait for the asynchronous process to finish, signalled by E.IsComplete being set;
            }

            //when e.IsComplete = true
            encryptor.Output(ref ciphertextTextbox);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Encryptor encryptor = null;

            if (encryptButton.Text == "Stop")
            {
                StopAllEncryptors();
                encryptButton.Text = "Encrypt";
            }
            else
            {
                //AES
                if (encryptionMethodComboBox.SelectedIndex == 0)
                {
                    InstantiateAESEncryptor(ref encryptor);
                    StartAESOperation(ref encryptor);
                }
                //RSA
                if (encryptionMethodComboBox.SelectedIndex == 1)
                    MessageBox.Show("Being developed soon!");
                //TripleDes
                if (encryptionMethodComboBox.SelectedIndex == 2)
                    MessageBox.Show("Being developed soon!");
                //Blowfish
                if (encryptionMethodComboBox.SelectedIndex == 3)
                    MessageBox.Show("Being developed soon!");
                //TwoFish
                if (encryptionMethodComboBox.SelectedIndex == 4)
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