using CaesarCipherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherBreaker
{
    internal class CaesarCipherBreaker
    {
        static readonly char[] PolishLetterFrequency = { 'a', 'i', 'o', 'e', 'z', 'n', 'r', 's', 'w', 'd', 't', 'k', 'y', 'p', 'm', 'u', 'j', 'l', 'c', 'b', 'g', 'h', 'f', 'q', 'v', 'x' };

        public static Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            var frequency = new Dictionary<char, int>();
            foreach (char ch in text.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    if (frequency.ContainsKey(ch))
                        frequency[ch]++;
                    else
                        frequency[ch] = 1;
                }
            }
            return frequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public static List<string> BreakCipher(string text, int topResults)
        {
            var frequency = CalculateLetterFrequency(text);
            char mostFrequentChar = frequency.First().Key;

            List<string> possibleDecryptions = new List<string>();
            foreach (char commonChar in PolishLetterFrequency)
            {
                int shift = (mostFrequentChar - commonChar + 26) % 26;
                string decryptedText = CaesarCipher.Decrypt(text, shift);
                possibleDecryptions.Add(decryptedText);

                if (possibleDecryptions.Count == topResults)
                    break;
            }

            return possibleDecryptions;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Podaj zaszyfrowany tekst:");
                string text = Console.ReadLine();

                Console.WriteLine("Podaj liczbę najbardziej prawdopodobnych kombinacji do wyświetlenia (do 10):");
                int topResults;
                while (!int.TryParse(Console.ReadLine(), out topResults) || topResults < 1 || topResults > 10)
                {
                    Console.WriteLine("Podaj liczbę z zakresu od 1 do 10:");
                }

                List<string> decryptions = BreakCipher(text, topResults);
                Console.WriteLine("Najbardziej prawdopodobne odszyfrowane teksty:");
                for (int i = 0; i < decryptions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {decryptions[i]}");
                }
            }
        }

    }
}
