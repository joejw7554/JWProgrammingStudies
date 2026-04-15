using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/11726
class B_11726
{
    const int MAX = 1000;
    static void Main()
    {
        //string test = @"9";
        // StringReader reader = new StringReader(test);
        using var reader = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();


        string line = reader.ReadLine();
        if (line != null)
        {
            int N = int.Parse(line);
            int[] memo = new int[Math.Max(N + 1, 3)];

            memo[1] = 1;
            memo[2] = 2;

            for (int i = 3; i <= N; i++)
            {
                memo[i] = (memo[i - 1] + memo[i - 2]) % 10007;
            }

            sb.AppendLine(memo[N].ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
