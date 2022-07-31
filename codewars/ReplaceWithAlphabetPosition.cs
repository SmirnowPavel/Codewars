namespace Codewars
{
    public class ReplaceWithAlphabetPosition
    {
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