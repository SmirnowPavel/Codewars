using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class WeirdStringCase
    //Write a function toWeirdCase that accepts a string, and returns the same string with all even indexed characters in each word upper cased,
    //and all odd indexed characters in each word lower cased.
    //The indexing just explained is zero based, so the zero-ith index is even,
    //therefore that character should be upper cased and you need to start over for each word.
    {
        public static string ToWeirdCase(string s)
        {
            string result = string.Empty;
            foreach (string word in s.Split().ToArray())
            {
                string a = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0 || i % 2 == 0)
                        a += char.ToUpper(word[i]);
                    else
                        a += char.ToLower(word[i]);
                }
                result += a +" ";
            }
            return result.Trim();
        }
    }
}
