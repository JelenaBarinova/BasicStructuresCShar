using System;

public static class QuickS
{
  public static void RunQuickSort()
  {
    Console.WriteLine("QuickSort");
    Console.WriteLine("1. Random numbers:");
    int[] arr = {8, 5, 10, 7, 3, 9};
    int[] arrSorted = QuickSort(arr);
    foreach (int i in arrSorted)
    Console.Write(i.ToString() + " ");
    Console.WriteLine();

    Console.WriteLine("2. Array containing one item:");
    int[] arr2 = {650};
    int[] arr2Sorted = QuickSort(arr2);
    foreach (int i in arr2Sorted)
    Console.Write(i.ToString() + " ");
    Console.WriteLine();

    Console.WriteLine("3. Empty array:");
    int[] arr3 = {};
    int[] arr3Sorted = QuickSort(arr3);
    foreach (int i in arr3Sorted)
    Console.Write(i.ToString() + " ");
    Console.WriteLine();

    Console.WriteLine("4. Two items array:");
    int[] arr4 = {8, 6};
    int[] arr4Sorted = QuickSort(arr4);
    foreach (int i in arr4Sorted)
    Console.Write(i.ToString() + " ");
    Console.WriteLine();
  }

  public static int[] QuickSort(int[] arr)
  {
    int n = arr.Length;
    if (n == 0)
    {
      return arr;
    }
    if (n == 1)
    {
      return arr;
    }
    if (n == 2)
    {
      if (arr[0] > arr[1])
      {
        Exch(arr, 0, 1);
      }
      return arr;
    }
    SortInner(arr, 0, n - 1);
    return arr;
  }

  private static void SortInner(int[] arr, int start, int end)
  {
    if (start >= end) return;
    int p = Partition(arr, start, end);
    SortInner(arr, start, p);
    SortInner(arr, p + 1, end);
  }

  private static int Partition(int[] arr, int start, int end)
  {
    int partitionIndex = start;
    int partitionItem = arr[partitionIndex];
    int i = start + 1, j = end;
    while (i <= j && i <= end && j >= 0)
    {
      if (partitionItem >= arr[i])
      {
        i++;
      }
      else if (partitionItem < arr[j])
      {
        j--;
      }
      else
      {
        Exch(arr, i, j);
        i++;
        j--;
      }
    }
    Exch(arr, partitionIndex, j);
    return j;
  }

  private static void Exch(int[] arr, int i, int j)
  {
    int tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
  }
}