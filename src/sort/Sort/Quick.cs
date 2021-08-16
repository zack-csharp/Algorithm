using Sort.Interface;

namespace Sort
{
    public class Quick : ISort
    {
        public void Sort(int[] arr)
        {
            int arrLength = arr.Length;
            QuickSort(arr, 0, arrLength - 1);
        }

        void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int i, j, x;
                i = leftIndex;
                j = rightIndex;
                x = arr[i];

                while (i < j)
                {
                    while (i < j && arr[j] > x)
                    {
                        j--;
                    }

                    if (i < j)
                    {
                        arr[i++] = arr[j];
                    }

                    while (i < j && arr[i] < x)
                    {
                        i++;
                    }

                    if (i < j)
                    {
                        arr[j--] = arr[i];
                    }
                }

                arr[i] = x;

                QuickSort(arr, leftIndex, i - 1);
                QuickSort(arr, i + 1, rightIndex);
            }
        }
    }
}
