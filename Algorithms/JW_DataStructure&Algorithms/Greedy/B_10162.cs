using System;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/10162
class B_10162
{
    static void Main()
    {
        var input = int.Parse(Console.ReadLine());
    

        int A = 300;
        int B = 60;
        int C = 10;

        int[] timers = new int[3] { 300, 60, 10 };
        List<int> counts = new List<int>();

        foreach (int num in timers)
        {
            int count = input / num;
            counts.Add(count);
            input -= num * count;
        }

        if (input != 0)
        {
            Console.WriteLine(-1);
        }
        else
        {

            Console.Write(string.Join(" ", counts));
        }
    }
}
