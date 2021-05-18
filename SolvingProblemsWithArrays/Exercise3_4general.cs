using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingProblemsWithArrays
{
    class Exercise3_4general
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
        private const string Cipher = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";

        public static char EncryptChar(char x)
        {
            return EncryptOrDecryptChar(x, Alfabet, Cipher);
        }

        public static char DecryptChar(char x)
        {
            return EncryptOrDecryptChar(x, Cipher, Alfabet);
        }

        public static char EncryptOrDecryptChar(char x, string from, string to)
        {
            if (!char.IsLetter(x)) return x;
            var index = from.IndexOf(x);
            return to[index];
        }
    }
}
