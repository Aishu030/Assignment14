using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assignment14
{
       internal class Program
        {
            public static void BubbleSort(int[] arr)
            {
                int n = arr.Length;
                int noSwap = 0;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;

                            noSwap++;
                        }
                    }

                    if (!swapped)
                    {
                        break;
                    }
                }
            }

            public static void InsertionSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 1; i < n; i++)
                {
                    int key = arr[i];
                    int j = i - 1;
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
            }

            public static void Print(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
            }

            public static bool IsSorted(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                        return false;
                }
                return true;
            }

            static void Main(string[] args)
            {
                int[] Barr = { 55, 21, 13, 58, 45, 75, 87 };
                int[] Iarr = { 10, 54, 22, 9, 5, 33 , 2};
                Console.WriteLine("Print Array without sort \n");
                Print(Barr);
                Print(Iarr);

                Stopwatch stopwatch = new Stopwatch();

                // Bubble Sort
                stopwatch.Start();
                BubbleSort(Barr);
                stopwatch.Stop();
                Console.WriteLine("After Bubble Sort \n ");
                Print(Barr);
               Console.WriteLine($"array sorted or not :\t{IsSorted(Barr)} \n");
               Console.WriteLine($"Bubble Sort Time Taken: {stopwatch.Elapsed.TotalMilliseconds} milliseconds \n");
               

                // Insertion Sort
                stopwatch.Restart();
                InsertionSort(Iarr);
                stopwatch.Stop();
                Console.WriteLine("After Insertion Sort \n ");
                Print(Iarr);
                Console.WriteLine($"array sorted or not :\t{IsSorted(Iarr)} \n");
                Console.WriteLine($"Insertion Sort Time Taken: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
          

            Console.ReadKey();
            }
        }
    }
