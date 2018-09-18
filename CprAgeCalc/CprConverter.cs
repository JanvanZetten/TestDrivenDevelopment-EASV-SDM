using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgramming
{
    public static class CprConverter
    {
        public static int GetYear(int cpr)
        {
            var lastFour = cpr % 10000;
            var lastTwoOfYear = (cpr / 10000) % 100;

            int firstTwo;

            if(lastFour <= 3999)
            {
                firstTwo = 19;
            }else if (lastTwoOfYear <= 36 && lastFour <= 4999)
            {
                firstTwo = 20;
            }
            else if (lastFour <= 4999)
            {
                firstTwo = 19;
            }
            else if (lastTwoOfYear <= 57 && lastFour <= 5999)
            {
                firstTwo = 20;
            }
            else if (lastFour <= 5999)
            {
                firstTwo = 18;
            }
            else if (lastTwoOfYear <= 57 && lastFour <= 6999)
            {
                firstTwo = 20;
            }
            else if (lastFour <= 6999)
            {
                firstTwo = 18;
            }
            else if (lastTwoOfYear <= 57 && lastFour <= 7999)
            {
                firstTwo = 20;
            }
            else if (lastFour <= 7999)
            {
                firstTwo = 18;
            }
            else if (lastTwoOfYear <= 57 && lastFour <= 8999)
            {
                firstTwo = 20;
            }
            else if (lastFour <= 8999)
            {
                firstTwo = 18;
            }
            else if (lastTwoOfYear <= 36 && lastFour <= 9999)
            {
                firstTwo = 20;
            }
            else
            {
                firstTwo = 19;
            }

            return firstTwo * 100 + lastTwoOfYear;

        }
    }
}
