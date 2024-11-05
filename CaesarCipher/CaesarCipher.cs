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
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1. Szyfruj tekst");
                Console.WriteLine("2. Odszyfruj tekst");
                string option = Console.ReadLine();

                Console.WriteLine("Podaj tekst:");
                string text = Console.ReadLine();

                Console.WriteLine("Podaj klucz:");
                int shift = int.Parse(Console.ReadLine());

                if (option == "1")
                {
                    string encryptedText = Encrypt(text, shift);
                    Console.WriteLine($"Zaszyfrowany tekst: {encryptedText}");
                }
                else if (option == "2")
                {
                    string decryptedText = Decrypt(text, shift);
                    Console.WriteLine($"Odszyfrowany tekst: {decryptedText}");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa opcja");
                }

                Console.WriteLine();
            }
        }
    }
}
