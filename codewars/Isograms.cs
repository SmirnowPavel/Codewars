namespace Codewars
{
    public class Isograms
        //DESCRIPTION:
        //An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        //Implement a function that determines whether a string that contains only letters is an isogram.
        //Assume the empty string is an isogram. Ignore letter case.
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            if (str == null)
                return true;
            string newS = string.Empty;
            foreach (char ch in str)
            {
                while (!newS.Contains(ch) & !newS.Contains(ch))
                    newS += ch;
            }
             if (!(newS.Length == str.Length))  
                return false;
            return true;    
        }
    }
}
