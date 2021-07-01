using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 8, 4, 10, 9, 11 };
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
            for (int i = 0; i < arrLength; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    var currentElement = arr[j];
                    var nextElement = arr[j + 1];
                    if (currentElement > nextElement)
                    {
                        arr[j] = nextElement;
                        arr[j + 1] = currentElement;
                    }
                }
            }
        }
    }
}
