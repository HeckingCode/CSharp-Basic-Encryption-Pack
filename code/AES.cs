using System;
using System.ComponentModel;

namespace EncryptionHeckingCode
{
    internal class AES : Encryptor
    {
        private BackgroundWorker bw;
        private Key key;

        public AES()
        {
            //called if random checkbox is ticked meaning we genertae a key 
            //just for now assume length is 128 (must be multiple of 32) and alphanumeric is true until UI updated 
            key = new Key(128, true);
        }

        public AES(string input)
        {
            //called if the user wants to input a string to be their key
            key = new Key(input);
        }

        public override void Start(bool encrypt)
        {
            bw = new BackgroundWorker();
            if (encrypt)
                bw.DoWork += Encrypt;
            else
                bw.DoWork += Decrypt;
            bw.RunWorkerAsync();
            bw.WorkerSupportsCancellation = true;
        }

        public override void Stop()
        {
            bw.CancelAsync();
        }

        private void Encrypt(object sender, EventArgs e)
        {
        }

        private void Decrypt(object sender, EventArgs e)
        {
        }

        public static bool IsValidKey(string key)
        {
            return key.Length >= 128 && key.Length % 32 == 0;
        }
    }
}