using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingProblemsWithArrays
{
    class CipherCreator
    {
        public static string Create()
        {
            var random = new Random();
            var alfabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ");
            for (int i = 0; i < alfabet.Length; i++)
            {
                var randomIndex = random.Next(0, alfabet.Length - 2);
                if (randomIndex >= i) randomIndex++;

                var tmp = alfabet[i];
                alfabet[i] = alfabet[randomIndex];
                alfabet[randomIndex] = tmp;
            }
            return alfabet.ToString();
        }
    }
}
