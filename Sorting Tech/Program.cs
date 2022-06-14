using System;

namespace Sorting_Tech
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 140,200,28,180,58 };
            Console.WriteLine("Before Selection Sort\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;
                    }
                }
                int smallerNumber = arr[index];
                arr[index] = arr[i];
                arr[i] = smallerNumber;
            }

            Console.WriteLine("\nAfter Selection Sort\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
// Selection sort example
            /*int[] arr = { 29, 72, 98, 13, 87 };
            Console.WriteLine("Before Selection Sort\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;//searching for lowest index  
                    }
                }
                int smallerNumber = arr[index];
                arr[index] = arr[i];
                arr[i] = smallerNumber;
            }

            Console.WriteLine("\nAfter Selection Sort\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }*/





     //bubble sort example
     /*int[] arr = new int[5] { 20,7,41,12,50 };
            int num = 5, temp;
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            for (int x = 0; x < num - 1; x++)
            {
                for (int y = 0; y < num - x - 1; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }*/
           /* int[] arr = new int[5] { 5, 3, 8, 4, 6 };
            int num = 5, temp;
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            for (int x = 0; x < num - 1; x++)
            {
                for (int y = 0; y < num - x - 1; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }*/

        }
    }
}
