namespace Codewars
{
    public class ReplaceWithAlphabetPosition
    {
        // DESCRIPTION:
        //In this kata you are required to, given a string, replace every letter with its position in the alphabet.
        //If anything in the text isn't a letter, ignore it and don't return it.
        //"a" = 1, "b" = 2, etc.


        public static string AlphabetPosition(string text)
        {
            text = text.ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; 
            char [] chars = text.ToCharArray();
            string result = string.Empty;
            foreach (char letter in chars)
            {
                if (alphabet.Contains(letter))
                    result += alphabet.IndexOf(letter) + 1 + " ";
            }
            if (result.EndsWith(" "))
                    result = result[..^1];
            return result;
        }
    }   
}