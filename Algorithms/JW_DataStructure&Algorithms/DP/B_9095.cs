using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/9095
class B_9095
{
    const int MAX = 10;
    static void Main()
    {
        string test = @"3
4
7
10";
        //StringReader reader = new StringReader(test);
        StreamReader reader = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();


        //미리 구하는 구간
        int[] dp = new int[MAX + 1];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 4;

        for (int i = 4; i <= MAX; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }


        string line = reader.ReadLine();
        if (line != null)
        {
            int T = int.Parse(line);

            while (T > 0)
            {
                string Input = reader.ReadLine();
                if (Input != null)
                {
                    int N = int.Parse(Input);
                    sb.AppendLine(dp[N].ToString());
                    T--;
                }
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
