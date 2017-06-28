using System;
using System.Linq;

namespace SimpleEncryption1_Codewars
{
    public class Kata
    {
        public static string Encrypt(string text, int n)
        {
            //do while n>0
            do
            {
                var secondChar = "";
                var firstChar = "";
                //string1 = ch that are 2nd char from the string
                for (int i = 1; i < text.Length; i += 2)
                {
                    secondChar += text[i];
                }
                //string2 = ch that are 1st char from the string
                for (int i = 0; i < text.Length; i += 2)
                {
                    firstChar += text[i];
                }
                //string1 + string2 = text
                var rv = secondChar + firstChar;
                return rv;
            }
            while (n > 0);
        }

        public static string Decrypt(string encryptedText, int n)
        {
            do
            {
                //split encryptedText/2
                var half = encryptedText.Length / 2;
                var str2 = encryptedText.Substring(0, half);
                var str1 = encryptedText.Substring((0 + half), half);
                //replace char
                if (str2.Length == 0) return str1;
                if (str1.Length == 0) return str2;

                var result = Enumerable.Range(0, encryptedText.Length)
                    .Select(i => (i % 2 == 0 ? str2 : str1)[i / 2])
                    .ToString();

                return result;
            }
            while (n > 0);
        }
    }
    class Program
    {
        static void Main(string[] args) { }
    }
}