//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;
//using System.Runtime.Intrinsics.Arm;

////https://www.acmicpc.net/problem/1463
//class B_1463
//{
//    const int MAX = 1000_000;
//    static void Main()
//    {
//        //string test = @"2";
//        //StringReader reader = new StringReader(test);
//        using StreamReader reader = new StreamReader(Console.OpenStandardInput());
//        StringBuilder sb = new StringBuilder();

//        int[] dp = new int[MAX + 1];
//        Array.Fill(dp, int.MaxValue);
//        dp[1] = 0;

//        for (int i = 2; i <= MAX; i++)
//        {
//            dp[i] = Math.Min(dp[i], dp[i - 1] + 1);

//            if (i % 2 == 0)
//            {
//                dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
//            }

//            if (i % 3 == 0)
//            {
//                dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
//            }
//        }

//        string line = reader.ReadLine();
//        if (line != null)
//        {
//            int N = int.Parse(line);
//            sb.Append(dp[N]);
//        }

//        Console.Write(sb.ToString());
//    }
//}
