using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hecking_encryption
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

            public Key(int length, string type)
            {
                //0 alphanumerical, 2 = ascii range 32 -> 126
                Generate(length, type);
            }
            internal static string Generate(int length, string type)
            {
                 Random rnd = new Random();
                 string key = "";
                 List<char> alphabet = new List<char>();
               
                int lower = 0,   higher = 0,   hook= 0,  jump = 0;
                if (type == "0")
                {
                     lower = 65;  higher = 123;  hook = 91;  jump = 97;
                }
                if(type == "1")
                {
                    lower = 32; higher = 126; hook = 91; jump = 92;
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
