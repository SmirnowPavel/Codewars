using System;
using System.Linq;


namespace Codewars
{
    public class MovingZeroesToEnd
    //DESCRIPTION:
    //Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

    {
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
