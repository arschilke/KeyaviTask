using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyaviTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>();
            input.AddRange(args.Select(x => int.Parse(x)));

            int thirdMax = Program.ThirdLargest(input);
            Console.WriteLine($"The third largest element of {string.Join(",", input)} is {thirdMax}");
        }

        /// <summary>
        /// This method will return the third largest number
        /// </summary>
        /// <param name="numbers">List of intergers</param>
        public static int ThirdLargest(List<int> numbers)
        {
            if (numbers.Count < 3)
            {
                throw new InvalidOperationException("Collection must have at least 3 values");
            }
            int max = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            foreach (var num in numbers)
            {
                if (max < num)
                {
                    max3 = max2;
                    max2 = max;
                    max = num;
                }
                else if (max2 < num)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if (num > max3)
                    max3 = num;
            }
            return max3;
        }

    }
}

