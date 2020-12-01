using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int[] array = new[] { 1, 2, 3, 3, 4, 5, 5 };
            MaxIndex(array);
        }
        public static int MaxIndex(int []array)
        {
            if (array.Length == 0)
                return -1;

            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
