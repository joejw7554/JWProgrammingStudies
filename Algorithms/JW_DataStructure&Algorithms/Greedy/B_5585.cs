using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

//https://www.acmicpc.net/problem/5585

class B_5585
{
    static void Main()
    {
        var input = int.Parse(Console.ReadLine());
        int remian = 1000 - input;
        int answer = 0;

        int[] changes = { 500, 100, 50, 10, 5, 1 };

        for(int i=0; i<changes.Length;i++)
        {
            answer += remian / changes[i];
            remian = remian % changes[i];
        }

        Console.WriteLine(answer);

    }
}
