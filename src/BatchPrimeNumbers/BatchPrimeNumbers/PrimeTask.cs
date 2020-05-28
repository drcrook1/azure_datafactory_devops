using System;
using System.Collections.Generic;
using System.Text;

namespace BatchPrimeNumbers
{
    public class PrimeTask
    {
        public static void TaskMain(string[] args)
        {
            if(args == null || args.Length != 2)
            {
                throw new Exception("Must supply --start x and --end y as arguments!");
            }
            int start = Int32.Parse(args[1]);
            int end = Int32.Parse(args[2]);

            var foundPrimes = FindPrimes(start, end);
            Console.WriteLine(string.Join("\t", foundPrimes));
        }

        private static List<int> FindPrimes(int start, int end)
        {
            List<int> foundPrimes = new List<int>();

            for(int i = start; i <= end; i++)
            {
                if(i % 2 == 0)
                {
                    foundPrimes.Add(i);
                }
            }

            return foundPrimes;
        }
    }
}
