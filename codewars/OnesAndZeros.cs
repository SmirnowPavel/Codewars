namespace Codewars
{
    public class OnesAndZeros
        //Given an array of ones and zeroes, convert the equivalent binary value to an integer.
        //Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.
    {
        public static int BinaryArrayToNumber(int[] binaryArray)
        {
            string s = string.Empty;
            foreach(int i in binaryArray)
            {
                s += i.ToString();
            }
            int a = Convert.ToInt32(s, 2);
            return a;
        }
    }
}
