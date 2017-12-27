using System;
using System.Collections.Generic;
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

        private List<Encryptor> arr = new List<Encryptor>();


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
            if (EncryptButton.Text == "Stop")
            {
                foreach (Encryptor f in arr)
                {
                    f.Stop();
                    EncryptButton.Text = "Encrypt";
                    arr.Remove(f);
                }
            }
            else
            {
                Encryptor E = null;



                //AES
                if (encryptionMethodComboBox.SelectedIndex == 0)
                {
                    if (RandomKeyCheckBox.Checked)
                    {
                        //start with random generated key
                        E = new AES();
                        MessageBox.Show("Made E 2");
                    }
                    else
                    {
                        //start with user input key
                        if (encryptionKeyTextbox.Text.Length >= 128 && (encryptionKeyTextbox.Text.Length % 32) == 0)
                        {
                            E = new AES(encryptionKeyTextbox.Text);
                            MessageBox.Show("Made E");

                        }
                        else
                        {
                            MessageBox.Show("Key length must be greater than 128 and a multiple of 32");

                        }


                    }
                    //if encrypt radio ticked to determine if encryption or decryption
                    //E.Start(encryptRadioButton.Checked);
                    if (E != null)
                    {
                        E.Start(encryptRadioButton.Checked);
                        EncryptButton.Text = "Stop";
                        arr.Add(E);

                        while (!E.complete)
                        {

                            //wait for the asynchronous process to finish, signalled by E.complete being set;
                        }

                        //when e.complete = true
                        E.Output(ref ciphertextTextbox);
                    }




                }
                //RSA
                if (encryptionMethodComboBox.SelectedIndex == 1)
                {
                    MessageBox.Show("Being developed soon!");
                }
                //TripleDes
                if (encryptionMethodComboBox.SelectedIndex == 2)
                {
                    MessageBox.Show("Being developed soon!");
                }
                //Blowfish
                if (encryptionMethodComboBox.SelectedIndex == 3)
                {
                    MessageBox.Show("Being developed soon!");
                }
                //TwoFish
                if (encryptionMethodComboBox.SelectedIndex == 4)
                {
                    MessageBox.Show("Being developed soon!");
                }

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
