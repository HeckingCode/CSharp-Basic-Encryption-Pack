using System;

namespace EncryptionHeckingCode
{
    public class KeyGenerator
    {
        private static string keyCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static Random random = new Random();

        public static string NewKey(int length)
        {
            string key = "";
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, keyCharacters.Length);
                key += keyCharacters[index];
            }
            return key;
        }
    }
}
