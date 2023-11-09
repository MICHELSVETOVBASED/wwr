using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace NewGeneric
{
    class MainClass
    {
        static void Main()
        {
            string ss = Console.ReadLine();
            char[] ss1 = ss.ToCharArray();
            List<char> list = new List<char>(ss1);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 'O')
                    Console.WriteLine(i);
            }   
        }
    }
}