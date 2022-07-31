namespace Codewars
{
    public class TwoToOne

        //DESCRIPTION:
        //Take 2 strings s1 and s2 including only letters from a to z.
        //Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
    {
        public static string Longest(string s1, string s2)
        {
            string longest = string.Empty;
            char[] s3 = (s1 + s2).ToCharArray();
            char tmp;
            for (int i = 0; i < s3.Length; i++)
            {
                for (int j = i + 1; j < s3.Length; j++)
                {
                    if (s3[i] > s3[j])
                    {
                        tmp = s3[i];
                        s3[i] = s3[j];
                        s3[j] = tmp;
                    }
                }
            }
            foreach (char ch in s3)
            {
                while (!longest.Contains(ch))
                    longest += ch;
            }
            return longest;
        }
    }
}
