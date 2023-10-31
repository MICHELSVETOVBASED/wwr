static int[] GetCubes(int startValue, int endValue)
{
    int res = endValue - startValue;
    int[] arr = new int[res + 1];

    if (startValue < 0)
    {
        for (int i = 0, k = startValue; i != arr.Length; i++)
        {
            arr[i] = k;
            k++;
        }
    }
    double[] arr1 = Array.ConvertAll(arr, i => (double)i);
    for (int i = 0; i != arr.Length; i++)
    {
        arr1[i] = Math.Pow(arr[i], 3);
    }
    int[] arr2 = new int[res + 1];
    for (int i = 0; i != arr.Length; i++)
    {
        arr2[i] = Convert.ToInt32(arr1[i]);
    }
    return arr2;
    RETURN




}
static void PrintSum()
{
    int sum = 0;
    for (int i = 0; i != arr2.Length; i++)
    {
        sum += arr2[i];
    }
    Console.WriteLine(sum);

}
