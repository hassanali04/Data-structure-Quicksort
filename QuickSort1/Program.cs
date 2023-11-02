// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Concurrent;

/*class Program
{
    static int Partition(int[] arr,int low, int high)
    {
        int Pivot = arr[high];
        int i = low - 1; 
        for (int j = low; j < high; j++)
        {
            if (arr[j] <Pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        i++;
        int temp1 = arr[i];
        arr[i] = Pivot;
        arr[high] = temp1;
        return i;
    }        
    static void QuickSort(int[] arr,int low ,int high)
    {
        if(low < high)
        {
            int Pivitindex = Partition(arr,low,high);
            QuickSort(arr,low,Pivitindex-1);
            QuickSort(arr,Pivitindex+1,high);
        }
    }
    static void Main(string[] args)
    {
        int[] arr = { 4, 2, 6, 7, 8,   9 };
        int n = arr.Length;
        QuickSort(arr, 0, n - 1);
        Console.WriteLine("Sorted Array");
        for (int i = 0; i <n ; i++)
        {
            Console.WriteLine(arr[i] +" ");
        }
    }
}*/
class Program
{
    static int Partiton(int[] arr,int low,int high)
    {
        int Pivot = arr[high];
        int i = low-1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < Pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        i++;
        int temp1 = arr[i];
        arr[i] = Pivot;
        arr[high] = temp1;
        return i;


    }
    static void QuickSort(int[]arr,int low ,int high)
    {
        if(low < high)
        {
            int PivotIndex = Partiton(arr,low, high);
            QuickSort(arr, low, PivotIndex - 1);
            QuickSort(arr,PivotIndex+1, high);
        }
    } 
    static void Main(string[] args)
    {
        int[] arr = { 3, 4, 1,  5, 8,  9 };
        int n = arr.Length;
        QuickSort(arr,0,n-1);
        Console.WriteLine("QuickSort");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]+" ");
        }
    } 
}