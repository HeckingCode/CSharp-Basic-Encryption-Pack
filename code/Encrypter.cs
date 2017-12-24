using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionHeckingCode
{
    public abstract class Encrypter
    {
        public virtual string Key { get; set; }

        private static Random random = new Random();

        //Generates a key (given a length and KeyType) and returns the generated key)
        public string GenerateKey(int length, KeyType keyType)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int lower = 0, higher = 0, hook = 0, jump = 0;
            if (keyType == KeyType.Alphanumeric)
            {
                lower = 65; higher = 123; hook = 91; jump = 97;
            }
            if (keyType == KeyType.Random)
            {
                lower = 32; higher = 126; hook = 91; jump = 92;
            }
            for (int i = lower; i < higher; i++)
            {
                stringBuilder.Append(((char)(i)));
                if (i == hook)
                {
                    i = jump;
                }
            }

            string alphabet = stringBuilder.ToString();
            stringBuilder.Clear();

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(alphabet[random.Next(0, alphabet.Length)]);
            }
            return stringBuilder.ToString();
        }

        //Encrypts message with the Key and returns the encrypted string
        public abstract string Encrypt(string message);

        //Decrypts message with the Key and returns the decrypted string
        public abstract string Decrypt(string message);
    }
}
