using System;

public static class QuickS
{
  public static void RunQuickSort()
  {
    bool result;

    Console.WriteLine("QuickSort");
    Console.WriteLine("1. Random numbers:");
    result = TestQuickSort(new int[]{8, 5, 9, 10, 2, 1, 7});
    Console.WriteLine(result?"OK":"Failed");

    Console.WriteLine("2. Array containing one item:");
    result = TestQuickSort(new int[]{650});
    Console.WriteLine(result?"OK":"Failed");

    Console.WriteLine("3. Empty array:");
    result = TestQuickSort(new int[]{});
    Console.WriteLine(result?"OK":"Failed");


    Console.WriteLine("4. Two items array:");
    result = TestQuickSort(new int[]{6, 5});
    Console.WriteLine(result?"OK":"Failed");

  }
  public static bool TestQuickSort(int[] arr)
  {
    int[] arrSorted = QuickSort(arr);
    Array.Sort(arr);
    int i = 0;
    while (i < arr.Length)
    {
      if (arr[i] != arrSorted[i])
      {
        return false;
      }
      i++;
    }
    return true;
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