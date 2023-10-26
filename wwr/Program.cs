using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        //double[] arr2 = new double[endValue - startValue];
        PrintSum(Cubarize(startValue, endValue));
        
        
    }
    static int [] Cubarize(int startValue, int endValue)
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
            
            

        }
        double[] arr1 = Array.ConvertAll(arr, i => (double)i);
        for (int i = 0; i != arr.Length; i++)
        {
            arr1[i] = Math.Pow(arr[i], 3);
            Console.WriteLine(arr1[i]);
        }
        int[] arr2 = new int[res + 1];
        for ( int i = 0; i!=arr.Length;i++)
        {
            arr2[i] = Convert.ToInt32(arr1[i]);
        }
        return arr2;
   
        


    }
    public void PrintSum(int[] arr2)
    {
        int sum = 0;
        for (int i = 0; i != arr2.Length; i++)
        {
            sum += arr2[i];
        }
        Console.WriteLine(sum);

    }
}


