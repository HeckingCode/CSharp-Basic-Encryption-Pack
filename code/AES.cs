using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionHeckingCode
{
    class AES : Encryptor
    {
        private BackgroundWorker bw;
        private Key key;            

       public AES()
        {
            //called if random checkbox is ticked meaning  we genertae a key 
                //just for now assume length is 128 (must be multiple of 32) and alphanumeric is true until UI updated 
               key = new Key(128, true); 
        }

        public AES(string input)
        {
            //called if the user wants to input a string to be their key
            key = new Key(input);
        }

        public override void Start(bool Enc)
        {
            this.bw = new BackgroundWorker();
            if (Enc)
            {
                this.bw.DoWork += Encrypt;
            }
            else
            {
                this.bw.DoWork += Decrypt;
            }
            this.bw.RunWorkerAsync();
            this.bw.WorkerSupportsCancellation = true;
        }

        public override void Stop()
        {
            this.bw.CancelAsync();
        }

        private void Encrypt(object sender, EventArgs e)
        {
           
        }

        private void Decrypt(object sender, EventArgs e)
        {

        }
    }
}
