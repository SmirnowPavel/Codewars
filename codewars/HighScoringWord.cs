namespace Codewars
{
    public class HighestScoringWord
    {
        public static string High(string str) => str.Split().OrderBy(x => x.Select(y => y - 'a' + 1).Sum()).Last();
        //{
        //   return str.Split(' ', '.').MaxBy(x => Enumerable.Sum(x.Select(x => x - 'a' + 1)));
        //   return s.Split().OrderBy(x => x.Select(y => y - 'a' + 1).Sum()).Last();
        //}
    }
}
