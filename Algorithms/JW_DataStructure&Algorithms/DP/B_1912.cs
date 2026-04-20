using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


//https://www.acmicpc.net/problem/1912
class B_1912
{
    static void Main()
    {
        string test = @"10
10 -4 3 1 5 6 -35 12 21 -1";
        StringBuilder sb = new StringBuilder();
        StringReader reader = new StringReader(test);


        int N = int.Parse(reader.ReadLine());

        int[] arr = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);

        int[] DP = new int[N];

        // 0,0 이전 것을 더한것 0,1 새로 시작한 값 
        DP[0] = arr[0];
        int Max = arr[0];

        for (int i = 1; i < N; i++)
        {
            DP[i] = Math.Max(arr[i], arr[i] + DP[i - 1]);
            Max = Math.Max(DP[i], Max);
        }

        sb.AppendLine(Max.ToString());

        Console.WriteLine(sb.ToString());
    }

}
