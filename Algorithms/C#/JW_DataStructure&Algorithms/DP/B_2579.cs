//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;

////https://www.acmicpc.net/problem/2579
//class B_2579
//{
//    static void Main()
//    {
//        string test = @"6
//10
//20
//15
//25
//10
//20";

//        //StringReader reader = new StringReader(test);
//        StreamReader reader = new StreamReader(Console.OpenStandardInput());
//        StringBuilder sb = new StringBuilder();

//        string line = reader.ReadLine();
//        if (line != null)
//        {
//            int N = int.Parse(line);

//            int[] scores = new int[N];

//            for (int i = 0; i < scores.Length; i++)
//            {
//                string scoreLine = reader.ReadLine();
//                if (scoreLine != null)
//                {
//                    scores[i] = int.Parse(scoreLine);
//                }
//            }


//            int[,] DP = new int[N, 3];
//            DP[0, 1] = scores[0];
//            DP[0, 2] = scores[0];

//            if (N >= 2)
//            {
//                DP[1, 1] = scores[1];
//                DP[1, 2] = scores[1] + DP[0, 1];
//            }


//            for (int i = 2; i < DP.GetLength(0); i++)
//            {
//                //한칸 건너뛰어서 도착
//                DP[i, 1] = Math.Max(DP[i - 2, 1], DP[i - 2, 2]) + scores[i];
//                //직전칸
//                DP[i, 2] = DP[i - 1, 1] + scores[i];
//            }

//            int result = Math.Max(DP[N - 1, 1], DP[N - 1, 2]);
//            sb.AppendLine(result.ToString());

//            Console.WriteLine(sb);
//        }




//    }
//}
