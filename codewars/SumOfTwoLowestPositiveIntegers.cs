namespace Codewars
{
    public class SumOfTwoLowestPositiveIntegers
        //DESCRIPTION:
        //Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers.
        //No floats or non-positive integers will be passed.
        //For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int tmp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                    }
                }
            }
            return numbers[0] + numbers[1];
        }
    }
}
    