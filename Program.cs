using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyaviTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>() { 4, 2, 8, 5, 8, 3, 1, 12, };
            int thirdMax = Program.ThirdLargest(input);
            Console.WriteLine($"The Third Largest of {string.Join(",", input)} is {thirdMax}");
        }

        /// <summary>
        /// This method will return the third largest number
        /// </summary>
        /// <param name="numbers"></param>
        public static int ThirdLargest(IEnumerable<int> numbers)
        {
            if (numbers.Count() < 3)
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
                Console.WriteLine($"max: {max}, max2: {max2}, max3: {max3}");
            }
            return max3;
        }

    }
}

