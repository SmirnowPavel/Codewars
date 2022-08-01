using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class FindTheParityOutlier

    //You are given an array (which will have a length of at least 3, but could be very large) containing integers.
    //The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
    //Write a method that takes the array as an argument and returns this "outlier" N.

    {
        public static int Find(int[] integers)
        {
            var oddIntCount = integers.Where(x => x % 2 != 0);
            var evenIntCount = integers.Where(x => x % 2 == 0);

            return oddIntCount.Count() == 1 ? oddIntCount.First() : evenIntCount.First();

            /*
            int oddIntCount = 0;
            int evenIntCount = 0;
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    evenIntCount++;
                    if(evenIntCount == 2)
                        for (int j = 0; j < integers.Length; j++)
                        {
                            if (integers[j] % 2 != 0)
                                result += integers[j];
                            
                        }
                }
                if (integers[i] % 2 != 0)
                {
                    oddIntCount++;
                    if (oddIntCount == 2)
                        for (int j = 0; j < integers.Length; j++)
                        {
                            if (integers[j] % 2 == 0)
                                result =+ integers[j];
                            
                        }
                }
            }
            return result;
            */
        }
    }
}
