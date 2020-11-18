using System;

namespace ConsoleApp1
{
    class Class
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите число:");
                String x1 = Console.ReadLine();
                int x = Convert.ToInt32(x1);
                arr[i] = x;
            }

            Bubblesort(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static int[] Bubblesort(int[] arr)
        {
            int tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }
    }
}
