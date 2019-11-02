using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace
{

    public static class MergeSortClass
    {

        public static void DoMergeSort(this int[] numbers)
        {
            var sortedNumbers = MergeSort(numbers);

            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }

        public static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers;

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2 > 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);
        }

        public static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                {
                    MoveValueFormSourceToResult(left, result);
                }
                else
                {
                    MoveValueFormSourceToResult(right, result);
                }
            }

            while (NotEmpty(left))
            {
                MoveValueFormSourceToResult(left, result);
            }

            while (NotEmpty(right))
            {
                MoveValueFormSourceToResult(right, result);
            }

            return result.ToArray();
        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFormSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
