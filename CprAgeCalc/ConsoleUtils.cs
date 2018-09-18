using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgramming
{
    public static class ConsoleUtils
    {
        /**
         * <summary>
         * Read an integer from console ReadLine();
         * Returns given integer.
         * </summary>
         **/
        public static int ReadInt()
        {
            return ReadInt("");
        }
        public static int ReadInt(string message)
        {
            Console.Write(message);

            int j;
            if (Int32.TryParse(Console.ReadLine(), out j))
            {
                return j;
            }
            else
            {
                Console.WriteLine("It can be an integer only!");
                return ReadInt(message);
            }
        }
    }
}
