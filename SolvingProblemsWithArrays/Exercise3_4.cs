using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace SolvingProblemsWithArrays
{
    class Exercise3_4
    {
        /*
            3-4 Here’s a variation on the array of const values. Write a program for creating a
            substitution cipher problem. In a substitution cipher problem, all messages
            are made of uppercase letters and punctuation. The original message is called
            the plaintext, and you create the ciphertext by substituting each letter with
            another letter (for example, each C could become an X). For this problem,
            hard-code a const array of 26 char elements for the cipher, and have your
            program read a plaintext message and output the equivalent ciphertext.
         */
        private const string Alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
        private const string Cipher  = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";

        public static string Encrypt(string plainText)
        {
            //return new string(plainText.Select(EncryptChar).ToArray());
            string cipherText = "";
            foreach (var character in plainText)
            {
                cipherText += EncryptChar(character);
            }
            return cipherText;
        }

        public static char EncryptChar(char plainChar)
        {
            if (!char.IsLetter(plainChar)) return plainChar;
            var indexInAlfabet = Alfabet.IndexOf(plainChar);
            return Cipher[indexInAlfabet];
        }

        public static string Decrypt(string cipherText)
        {
            string plainText = "";
            foreach (var character in cipherText)
            {
                plainText += DecryptChar(character);
            }
            return plainText;
        }

        public static char DecryptChar(char cipherChar)
        {
            if (!char.IsLetter(cipherChar)) return cipherChar;
            var indexInCipher = Cipher.IndexOf(cipherChar);
            return Alfabet[indexInCipher];
        }
    }
}
