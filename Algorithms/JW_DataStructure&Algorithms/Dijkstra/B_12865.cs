using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

//https://www.acmicpc.net/problem/12865
class B_12865
{
    static void Main()
    {
        string test = @"4 7
6 13
4 8
3 6
5 12";
        //StringReader reader = new StringReader(test);
        StreamReader reader = new StreamReader(Console.OpenStandardInput());

        StringBuilder sb = new StringBuilder();

        string line = reader.ReadLine();
        if (line != null)
        {
            int[] input = Array.ConvertAll(line.Split(), int.Parse);

            int N = input[0];
            int K = input[1];

            (int W, int V)[] list = new (int W, int V)[N];
            for (int i = 0; i < N; i++)
            {
                int[] row = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);
                list[i] = (row[0], row[1]);
            }

            int[] DP = new int[K + 1];

            for (int i = 0; i < N; i++)
            {
                int currentW = list[i].W;
                int currentV = list[i].V;
                for (int j = K; j >= currentW; j--)
                {
                    DP[j] = Math.Max(DP[j], DP[j - currentW] + currentV);
                }
            }

            sb.AppendLine((DP[K]).ToString());
            Console.WriteLine(sb.ToString());


        }
    }

}
