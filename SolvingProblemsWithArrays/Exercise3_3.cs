using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingProblemsWithArrays
{
    class Exercise3_3
    {
        public static bool IsSortedA(int[] numbers)
        {
            /*
             * 3-3 Write a bool function that is passed an array and the number of elements in
             * that array and determines whether the data in the array is sorted. This should
             * require only one pass!
             */
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] <= numbers[i]) return false;
            }
            return true;
        }

        public static bool IsSortedB(int[] numbers)
        {
            /*
             * 3-3 Write a bool function that is passed an array and the number of elements in
             * that array and determines whether the data in the array is sorted. This should
             * require only one pass!
             */
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= numbers[i - 1]) return false;
            }
            return true;
        }

        public static bool IsSortedC(int[] numbers)
        {
            /*
             * 3-3 Write a bool function that is passed an array and the number of elements in
             * that array and determines whether the data in the array is sorted. This should
             * require only one pass!
             */
            int? lastNumber = null;
            foreach (var number in numbers)
            {
                if (lastNumber.HasValue && lastNumber >= number) return false;
                lastNumber = number;
            }
            return true;
        }

    }
}
