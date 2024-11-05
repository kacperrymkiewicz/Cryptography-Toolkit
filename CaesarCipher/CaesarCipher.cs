using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    public class CaesarCipher
    {
        public static string Encrypt(string text, int key)
        {
            string result = "";

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    result += (char)((ch + key - offset) % 26 + offset);
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }

        public static string Decrypt(string text, int key)
        {
            return Encrypt(text, 26 - key);
        }

        static void Main(string[] args) 
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Encrypt text");
                Console.WriteLine("2. Decrypt text");
                string option = Console.ReadLine();

                Console.WriteLine("Enter the text:");
                string text = Console.ReadLine();

                Console.WriteLine("Enter the key:");
                int shift = int.Parse(Console.ReadLine());

                if (option == "1")
                {
                    string encryptedText = Encrypt(text, shift);
                    Console.WriteLine($"Encrypted text: {encryptedText}");
                }
                else if (option == "2")
                {
                    string decryptedText = Decrypt(text, shift);
                    Console.WriteLine($"Decrypted text: {decryptedText}");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

                Console.WriteLine();
            }
        }
    }
}
