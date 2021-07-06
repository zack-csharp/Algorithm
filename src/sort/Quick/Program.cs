using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 6, 8, 4, 10, 9, 11, 8 };
            Console.WriteLine("排序前:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Sort(arr);

            Console.WriteLine("排序后:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
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
                int pivotIndex = SelectPivotIndex(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, rightIndex);
            }
        }

        /// <summary>
        /// 选择基准值索引
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="leftIndex"></param>
        /// <param name="rightIndex"></param>
        private static int SelectPivotIndex(int[] arr, int leftIndex, int rightIndex)
        {
            int pivotIndex = leftIndex;
            int startIndex = pivotIndex + 1;
            for (int i = startIndex; i <= rightIndex; i++)
            {
                if (arr[i] < arr[pivotIndex])
                {
                    Swap(arr, i, startIndex);
                    startIndex++;
                }
            }

            Swap(arr, pivotIndex, startIndex - 1);

            return startIndex - 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
