using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionHeckingCode
{
    public class AES : Encrypter
    {
        public override string Key { get; set; }
        private string[] SBox = { 
            //Place SBox Here
        };

        private string Message;

        public AES(string message)
        {
            Key = GenerateKey(128, KeyType.Alphanumeric);
            Message = message;
        }
        
        public override string Encrypt(string message)
        {
            throw new NotImplementedException();
        }

        public override string Decrypt(string message)
        {
            throw new NotImplementedException();
        }
    }
}
