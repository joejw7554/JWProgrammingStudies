//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Runtime.Intrinsics.Arm;
//using System.Text;

////https://www.acmicpc.net/problem/1003
//class B_1003
//{
//    static void Main()
//    {
//        string test = @"2
//6
//22
//";
//        //TextReader reader = new StringReader(test);
//        StringBuilder sb = new StringBuilder();

//        StreamReader reader = new StreamReader(Console.OpenStandardInput());

//        string line1 = reader.ReadLine();
//        if (line1 == null) return;
//        int caseCount = int.Parse(line1);

//        (int, int)[] dp = new (int, int)[41];
//        dp[0] = (1, 0);
//        dp[1] = (0, 1);

//        for (int j = 2; j <= 40; j++)
//        {
//            int zeroCount = dp[j - 1].Item1 + dp[j - 2].Item1;
//            int oneCount = dp[j - 1].Item2 + dp[j - 2].Item2;
//            dp[j] = (zeroCount, oneCount);
//        }

//        for (int i = 0; i < caseCount; i++)
//        {
//            int n = int.Parse(reader.ReadLine());

//            sb.AppendLine($"{dp[n].Item1} {dp[n].Item2}");
//        }
//        Console.WriteLine(sb.ToString());
//    }

//}
