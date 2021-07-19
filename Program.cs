using System;

namespace search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How large is this list:");
            int size = Console.Read();
            int[] arr = Search.generate(size);
            Console.Read();
            Console.WriteLine("What number do you want to find:");
            int find = Console.Read();
            bool there = Search.find(arr, find);

            if (there)
            {
                Console.WriteLine("It's there!");
            }
            else
            {
                Console.WriteLine("It's not there unfortunatly");
            }
        }
    }

    public class Search
    {
        public static bool find(int[] arr, int x)
        {
            int mid = arr.Length / 2;
            int end = arr.Length;
            int begin = 0;

            while (end - begin > 1)
            {
                if (x == mid)
                    return true;
                else if (x < mid)
                {
                    end = mid;
                    mid = end / 2;
                }
                else if (x > mid)
                {
                    begin = mid;
                    mid = (begin + end) / 2;
                }
            }
            return false;
        }

        public static int[] generate(int len)
        {
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
    }
}
