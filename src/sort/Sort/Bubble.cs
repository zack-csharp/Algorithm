using Sort.Interface;

namespace Sort
{
    public class Bubble : ISort
    {
        public void Sort(int[] arr)
        {
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
