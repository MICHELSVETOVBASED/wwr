using System;
using System.Collections.Generic;


public class MainClass
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        PrintEven(GetMultiple(startValue, endValue));
    }
    static List<int> GetMultiple(int startValue, int endValue)
    {
        List<int> list = new List<int>();
        List<int> newlist = new List<int>();
        for (int i = startValue; i != endValue; i++)
        {
            list.Add(i);
        }
        for (int i = 0; i != list.Count; i++)
        {
            if (list[i] % 7 == 0)
            {
                newlist.Add(list[i]);
            }
        }
        return newlist;
    }
    static void PrintEven(List<int> newlist)
    {
        for (int i = 0; newlist[i] < newlist.Count; i++)
        {
            if (newlist[i] == 0)
            {
                newlist.Remove(newlist[i]);
            }
        }
        for (int i = 0; i <= newlist.Count; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write($"{newlist[i]} ");
            }
            else { continue; }
        }

    }
}


