using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipherApp
{
    internal class VigenereCipher
    {
        public static string Encrypt(string text, string key)
        {
            string result = "";
            int keyIndex = 0;

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char keyChar = key[keyIndex % key.Length];
                    int keyShift = char.IsUpper(keyChar) ? keyChar - 'A' : keyChar - 'a';

                    result += (char)((ch + keyShift - offset) % 26 + offset);
                    keyIndex++;
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }

        public static string Decrypt(string text, string key)
        {
            string result = "";
            int keyIndex = 0;

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char keyChar = key[keyIndex % key.Length];
                    int keyShift = char.IsUpper(keyChar) ? keyChar - 'A' : keyChar - 'a';

                    result += (char)((ch - keyShift + 26 - offset) % 26 + offset);
                    keyIndex++;
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Encrypt text");
                Console.WriteLine("2. Decrypt text");
                string option = Console.ReadLine();

                Console.WriteLine("Enter the text:");
                string text = Console.ReadLine();

                Console.WriteLine("Enter the key:");
                string key = Console.ReadLine();

                if (option == "1")
                {
                    string encryptedText = Encrypt(text, key);
                    Console.WriteLine($"Encrypted text: {encryptedText}");
                }
                else if (option == "2")
                {
                    string decryptedText = Decrypt(text, key);
                    Console.WriteLine($"Decrypted text: {decryptedText}");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }
    }
}
