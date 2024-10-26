using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipherApp
{
    internal class VigenereCipher
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania:");
            string text = Console.ReadLine();

            Console.WriteLine("Podaj klucz:");
            int shift = int.Parse(Console.ReadLine());
        }
    }
}
