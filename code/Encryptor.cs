using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionHeckingCode
{
    public class Encryptor
    {
        public bool complete = false;
        public string Result = null;

        public virtual string Encrypt()
        {
            return "";
        }

        public virtual string Decrypt()
        {
            return "";
        }

        public virtual void Output(ref RichTextBox t)
        {
            t.Text = this.Result;
            //self cancelling operation, nothing further to be done once text is generated and output
            this.Stop();
        }

        public virtual void Start(bool Encrypt)
        {

        }

        public virtual void Stop()
        {

        }
    

        public class Key
        {
            /// <summary>
            /// Encryption key and generator
            /// </summary>
            

           internal readonly string keyContent;
           internal readonly int length;

            /// <summary>
            /// Randomly generated key
            /// </summary>
            /// <param name="length">desired length of the key</param>
            /// <param name="alphanumeric">whether the key is alphanumeric (true) or not (false)</param>
           public  Key(int length, bool alphanumeric)
            {
               keyContent = Generate(length, alphanumeric);
                length = keyContent.Length;
            }
            
            /// <summary>
            /// User input key
            /// </summary>
            /// <param name="input"> key input by the user</param>
           public  Key(string input)
            {
                keyContent = input;
                length = keyContent.Length;
            }

            //keeping this static because if we want to generate a new key we may as well generate a completely new object to ensure
            //true random is implemented by not reusing the same random 
            internal static string Generate(int length, bool alphanumeric)
            {
                 Random rnd = new Random();
                 string key = "";
                 List<char> alphabet = new List<char>();
               
                int lower = 0,   higher = 0,   hook= 0,  jump = 0;
                if (alphanumeric)
                {
                     lower = 65;  higher = 123;  hook = 91;  jump = 97;
                }
                if(!alphanumeric)
                {
                    lower = 32; higher = 126; hook = 90; jump = 92;
                }
                for (int i = lower; i < higher; i++)
                {
                    alphabet.Add((char)(i));
                    if (i == hook)
                    {
                        i = jump;
                    }
                }
                for(int i =0; i < length; i++)
                {
                    key += alphabet[rnd.Next(0, alphabet.Count)];
                }
                return key;
            }
        }

        public class IV
        {

        }
    }
}
