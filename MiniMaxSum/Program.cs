using System;

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        int n = arr.Length;
        Int64 min = 900000000000;
        Int64 max = -90000000000;
        Int64 s = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                s = s + arr[j];
            }
            s = s - arr[i];
            if (s > max) max = s;
            if (s < min) min = s;
            s = 0;
        }
        Console.WriteLine(min + " " + max);


    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}