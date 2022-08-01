namespace Codewars
{
    public class HighestScoringWord

        //DESCRIPTION:
        //Given a string of words, you need to find the highest scoring word.
        //Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
        //You need to return the highest scoring word as a string.
        //If two words score the same, return the word that appears earliest in the original string.
        //All letters will be lowercase and all inputs will be valid.
    {
        public static string High(string str) => str.Split().OrderBy(x => x.Select(y => y - 'a' + 1).Sum()).Last();
        //{
        //   return str.Split(' ', '.').MaxBy(x => Enumerable.Sum(x.Select(x => x - 'a' + 1)));
        //   return s.Split().OrderBy(x => x.Select(y => y - 'a' + 1).Sum()).Last();
        //}
    }
}
