using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace
{
    class BubbleSortClass
    {
        public void BubbleSort(int[] numbers)
        {
            int tmp;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        tmp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = tmp;
                    }

                }
            }
        }
    }
}
