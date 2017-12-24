using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionHeckingCode
{
    public class Functions
    {
       public virtual string Encrypt()
        {
            return "";
        }

        public virtual string Decrypt()
        {
            return "";
        }

        public virtual void start()
        {

        }

        public virtual void stop()
        {

        }
    

        public class Key
        {
            /// <summary>
            /// Object for creating the key 
            /// </summary>
            

            readonly string keyContent;
            readonly int length;

            /// <summary>
            /// Random key generator 
            /// </summary>
            /// <param name="length">desired length of the key</param>
            /// <param name="alphanumeric">whether the key is alphanumeric (true) or not (false)</param>
             Key(int length, bool alphanumeric)
            {
                Generate(length, alphanumeric);
            }
            
            /// <summary>
            /// User input key
            /// </summary>
            /// <param name="input"> key input by the user</param>
             Key(string input)
            {
                keyContent = input;
                length = keyContent.Length;
            }

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
