using System;

class QuickSort
{
    static void Main(string[] args) {}

    static void QuicksortAlgorithm(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int teiler = Partition(arr, left, right);

            if (teiler > 1)
            {
                QuicksortAlgorithm(arr, left, teiler - 1);
            }
            if (teiler + 1 < right)
            {
                QuicksortAlgorithm(arr, teiler + 1, right);
            }
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int teiler = arr[left];
        while (true)
        {
            while (arr[left] < teiler)
            {
                left++;
            }
            while (arr[right] > teiler)
            {
                right--;
            }
            if (left < right)
            {
                if (arr[left] == arr[right]) return right;
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}