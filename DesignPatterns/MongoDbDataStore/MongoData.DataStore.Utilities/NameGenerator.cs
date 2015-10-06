using System;
using System.Text;

namespace MongoData.DataStore.Utilities
{

    public class NameGenerator
    {

        #region Private Variables.
        static readonly string[] Consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        static readonly string[] Vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        static readonly Random RandomObject = new Random();
        #endregion

        #region Methods.
        public static string GenerateName(int length = 10)
        {
            var name = new StringBuilder(100);
            var iCtr = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.

            name.Append(GetConsonant(true));
            name.Append(GetVowel());
            while (iCtr <= length)
            {
                name.Append(GetConsonant());
                name.Append(GetVowel());
                iCtr += 2;
            }
            return name.ToString();
        }
        #endregion

        #region Methods.
        private static string GetConsonant(bool isUpperCase = false)
        {
            var consonantsLength = Consonants.Length;
            return isUpperCase ? Consonants[RandomObject.Next(consonantsLength)].ToUpper() : Consonants[RandomObject.Next(consonantsLength)];
        }

        private static string GetVowel()
        {
            var vowelsLength = Vowels.Length;
            return Vowels[RandomObject.Next(vowelsLength)];
        }
        #endregion
    }

}