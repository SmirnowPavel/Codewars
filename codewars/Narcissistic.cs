namespace Codewars
{
    public class Narcissistic
        //DESCRIPTION:
        //A Narcissistic Number is a positive number which is the sum of its own digits,
        //each raised to the power of the number of digits in a given base.
        //In this Kata, we will restrict ourselves to decimal (base 10).
        //The Challenge:
        //Your code must return true or false (not 'true' and 'false') 
        //depending upon whether the given number is a Narcissistic number in base 10. 
        //This may be True and False in your language, e.g. PHP.
        //Error checking for text strings or other invalid inputs is not required,
        //only valid positive non-zero integers will be passed into the function.
    {
        public static bool IsNarcissistic(int value)
        {
            int power = value.ToString().Length;
            int sum = 0;
            char[] digits = value.ToString().ToArray();

            foreach (char digit in digits)
            {
                int newDigit = (int)Math.Pow(Convert.ToInt32(digit - '0'), power);
                sum += newDigit;
            }
            if (value == sum)
                return true;
            else
                return false;
        }
    }
}
