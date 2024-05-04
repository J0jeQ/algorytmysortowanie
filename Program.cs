using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int[] zwykla = { 64, 25, 12,35,544,4,3,45436,424,785,5775,564,364,657,13,4,24,563534, 22, 11,42,234,2,42,4,243,44,42,343,43,4343,3,4,432,434,5,5,5,566,5,7,6,7,4,6,3,6,43,5,45,45,5,45,6,5,7,75,43,5,6,4,6,5,4,6,4,6,4,2,3566,7,6 };
        int[] dwudzielna ={ 2,3 };
        int[] zwykla2 = { 64, 25, 12, 22, 11 };
        int[] dwudzielna1 ={ 2,2};
        int[] zwykla3 = { 64, 25, 12, 22, 11 };
        int[] dwudzielna5 ={1,2 };
        int[] zwykla5 = { 64, 25, 12, 22, 11 };
        int[] dwudzielna12 ={ 1,2};



        Console.WriteLine("Array before sorting:");
        PrintArray(zwykla);

        SelectionSortFunction(zwykla);
        //SelectionSortFunction(dwudzielna);
        //SelectionSortFunction(zwykla2);
        //SelectionSortFunction(dwudzielna1);
        //SelectionSortFunction(zwykla3);

        Console.WriteLine("\nArray after sorting:");
        PrintArray(zwykla);
    }

    static void SelectionSortFunction(int[] arr)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        stopwatch.Stop();
        var sw = stopwatch.ElapsedTicks;
        Console.WriteLine(sw);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        



    }
}