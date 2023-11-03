using System;

class Program
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        PrintSum(GetCubes(startValue, endValue));
    }
static int[] GetCubes(int startValue, int endValue)
{
    int res = endValue - startValue;
    int[] arr = new int[res + 1];

    int res1 = startValue + endValue;
    int[] arr8 = new int[res1 + 1];

    /*int res2 = endValue;
    int[] arr15 = new int[res2 + 1];*/
    switch (startValue)
    {
        case < 0:
            for (int i = 0, k = startValue; i != arr.Length; i++)
            {
                arr[i] = k;
                k++;
            }
            double[] arr1 = Array.ConvertAll(arr, i => (double)i);
            for (int i = 0; i != arr.Length; i++)
            {
                arr1[i] = Math.Pow(arr1[i], 3);
            }
            int[] arr2 = new int[res + 1];
            for (int i = 0; i != arr.Length; i++)
            {
                arr2[i] = Convert.ToInt32(arr1[i]);
            }

            return arr2;
        case >= 0:
            for (int i = 0, k = startValue; i != arr8.Length; i++)
            {
                arr8[i] = k;
                k++;
            }
            double[] arr9 = Array.ConvertAll(arr8, i => (double)i);
            for (int i = 0; i != arr8.Length; i++)
            {
                arr9[i] = Math.Pow(arr9[i], 3);
            }
            int[] arr10 = new int[res1 + 1];
            for (int i = 0; i != arr.Length; i++)
            {
                arr10[i] = Convert.ToInt32(arr9[i]);
            }

            return arr10;
        /*case 0:
            for (int i = 0, k = 0; i != arr15.Length; i++)
            {
                arr15[i] = k;
                k++;
            }
            double[] arr16 = Array.ConvertAll(arr15, i => (double)i);
            for (int i = 0; i != arr15.Length; i++)
            {
                arr16[i] = Math.Pow(arr16[i], 3);
            }
            int[] arr17 = new int[res2 + 1];
            for (int i = 0; i != arr15.Length; i++)
            {
                arr17[i] = Convert.ToInt32(arr16[i]);
            }
            return arr17;*/
    }

}

static void PrintSum(int[] arr2)
{
    int sum = 0;
    for (int i = 0; i != arr2.Length; i++)
    {
        sum += arr2[i];
    }
    Console.WriteLine(sum);


}
}
