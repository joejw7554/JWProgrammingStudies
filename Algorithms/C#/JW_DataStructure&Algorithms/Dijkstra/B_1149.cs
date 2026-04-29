//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;
//using System.Runtime.Intrinsics.Arm;

////https://www.acmicpc.net/problem/1149
//class B_1149
//{
//    static void Main()
//    {
//        string test = @"8
//71 39 44
//32 83 55
//51 37 63
//89 29 100
//83 58 11
//65 13 15
//47 25 29
//60 66 19";
//        //StringReader reader = new StringReader(test);
//        StreamReader reader = new StreamReader(Console.OpenStandardInput());
//        StringBuilder sb = new StringBuilder();



//        string line = reader.ReadLine();
//        if (line != null)
//        {
//            int N = int.Parse(line);


//            int[,] cost = new int[N + 1, 3];
//            for (int i = 1; i < cost.GetLength(0); i++)
//            {
//                string info = reader.ReadLine();

//                if (info == null) break;

//                int[] row = Array.ConvertAll(info.Split(), int.Parse);

//                for (int j = 0; j < cost.GetLength(1); j++)
//                {
//                    cost[i, j] = row[j];
//                }
//            }

//            //모든 경우의 수를 테스트 해봐야하는 상황

//            int[,] DP = new int[N + 1, 3];

//            for (int i = 0; i < DP.GetLength(1); i++)
//            {
//                DP[1, i] = cost[1, i];
//            }


//            for (int i = 2; i < cost.GetLength(0); i++)
//            {
//                DP[i, 0] = cost[i, 0] + Math.Min(DP[i - 1, 1], DP[i - 1, 2]);
//                DP[i, 1] = cost[i, 1] + Math.Min(DP[i - 1, 0], DP[i - 1, 2]);
//                DP[i, 2] = cost[i, 2] + Math.Min(DP[i - 1, 0], DP[i - 1, 1]);
//            }

//            int Min = int.MaxValue;
//            for (int i = 0; i < 3; i++)
//            {
//                Min = Math.Min(Min, DP[N, i]);
//            }

//            sb.AppendLine(Min.ToString());

//            Console.WriteLine(sb.ToString());
//        }


//    }
//}
