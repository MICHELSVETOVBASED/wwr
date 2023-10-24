using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        double[] arr2 = Cubarize(startValue, endValue);
        PrintSum(Cubarize(startValue, endValue));
    }
    static void Cubarize(int startValue, int endValue)
    {
        int res = endValue - startValue;
        int[] arr = new int[res+1];
        if (startValue < 0)
        {
            for (int i = 0, k = startValue; i != arr.Length; i++)
            {
                arr[i] = k;
                k++;
            }
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            double[] arr1 = Array.ConvertAll(arr, i => (double)i);
            for (int i = 0; i != arr.Length; i++)
            {
                arr1[i] = Math.Pow(arr[i], 3);
                Console.WriteLine(arr1[i]);
            }
            
            
            
        }
                
    }
    public double[] PrintSum(double[] arr1)
    {
        double sum = 0;
        for (int i = 0; i != arr1.Length; i++)
        {
            sum += arr1[i];


        }
        Console.WriteLine(sum);
        
    }
}


