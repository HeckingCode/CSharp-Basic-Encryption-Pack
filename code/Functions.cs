using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionHeckingCode
{
    public class Functions
    {
       internal virtual void Encrypt()
        {

        }

        internal virtual void Decrypt()
        {

        }

        public class Key
        {
            /// <summary>
            /// Object for creating the key 
            /// </summary>
            /// <param name="length">length of key</param>
            /// <param name="alphanumeric">true = alphanumeric, false = ascii range 32 ->126</param>s
            public Key(int length, bool alphanumeric)
            {
                
                Generate(length, alphanumeric);
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
