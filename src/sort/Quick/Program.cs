using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 6, 14, 4, 10, 9, 15, 8 };
            Console.WriteLine("排序前:");
            ShowResult(arr);

            Sort(arr);

            Console.WriteLine("排序后:");
            ShowResult(arr);
        }

        static void Sort(int[] arr)
        {
            int arrLength = arr.Length;
            QuickSort(arr, 0, arrLength - 1);
        }

        static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int i, j, x;
                i = leftIndex;
                j = rightIndex;
                x = arr[i];

                Console.WriteLine($"基准值：{x}");

                while (i < j)
                {
                    while (i < j && arr[j] > x)
                    {
                        j--;
                    }

                    if (i < j)
                    {
                        arr[i++] = arr[j];
                        ShowResult(arr);
                    }

                    while (i < j && arr[i] < x)
                    {
                        i++;
                    }

                    if (i < j)
                    {
                        arr[j--] = arr[i];
                        ShowResult(arr);
                    }
                }

                arr[i] = x;

                ShowResult(arr);

                QuickSort(arr, leftIndex, i - 1);
                QuickSort(arr, i + 1, rightIndex);
            }
        }

        static void ShowResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
