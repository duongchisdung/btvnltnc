using System;

class ArrayProcessor
{
    private int[] arr; 
    public void Input()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Display()
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    public void BubbleSort()
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public void QuickSort(int left, int right)
    {
        int i = left, j = right;
        int pivot = arr[(left + right) / 2];
        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        if (left < j) QuickSort(left, j);
        if (i < right) QuickSort(i, right);
    }

    public int LinearSearch(int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    public int BinarySearch(int key)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == key)
                return mid;
            if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    public int[] GetArray()
    {
        return arr;
    }
}

class Program
{
    static void Main()
    {
        ArrayProcessor ap = new ArrayProcessor();

        ap.Input();

        Console.WriteLine("\nMang ban dau:");
        ap.Display();

        ap.BubbleSort();
        Console.WriteLine("\nMang sau khi Bubble Sort:");
        ap.Display();

        int[] originalArray = ap.GetArray(); 
        ArrayProcessor ap2 = new ArrayProcessor();
        ap2 = new ArrayProcessor();
        Console.WriteLine("\nNhap lai mang de Quick Sort:");
        ap2.Input();
        ap2.QuickSort(0, ap2.GetArray().Length - 1);
        Console.WriteLine("Mang sau khi Quick Sort:");
        ap2.Display();

        Console.Write("\nNhap so can tim: ");
        int key = int.Parse(Console.ReadLine());

      
        int posLinear = ap.LinearSearch(key);
        Console.WriteLine(posLinear != -1
            ? $"Tim thay {key} tai vi tri (Linear Search): {posLinear}"
            : $"{key} khong co trong mang (Linear Search)");

        int posBinary = ap.BinarySearch(key);
        Console.WriteLine(posBinary != -1
            ? $"Tim thay {key} tai vi tri (Binary Search): {posBinary}"
            : $"{key} khong co trong mang (Binary Search)");
    }
}
