using System;

namespace Insertion
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

            for (int i = 1; i < arrLength; i++)
            {
                int previousIndex = i - 1;
                int currentElement = arr[i];

                Console.WriteLine($"当前值：{currentElement}");

                while (previousIndex >= 0 && arr[previousIndex] > currentElement)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex--;
                    ShowResult(arr);
                }

                arr[previousIndex + 1] = currentElement;

                ShowResult(arr);
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
