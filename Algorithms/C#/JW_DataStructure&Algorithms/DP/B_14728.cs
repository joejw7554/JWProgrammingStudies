//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;


////https://www.acmicpc.net/problem/14728
//class B_14728
//{
//    static void Main()
//    {
//        string test = @"3 310
//200 150
//50 40
//100 70";

//        StringReader reader = new StringReader(test);
//        //StreamReader reader = new StreamReader(Console.OpenStandardInput());
//        StringBuilder sb = new StringBuilder();

//        string line = reader.ReadLine();

//        if (line != null)
//        {
//            var input = Array.ConvertAll(line.Split(), int.Parse);

//            int n = input[0];
//            int availableTime = input[1];

//            int[] DP = new int[availableTime + 1];
//            for (int i = 0; i < n; i++)
//            {
//                string[] info = reader.ReadLine().Split();
//                int require = int.Parse(info[0]);
//                int score = int.Parse(info[1]);

//                for (int j = availableTime; j >= require; j--)
//                {
//                    if (DP[j - require] + score > DP[j])
//                    {
//                        DP[j] = DP[j - require] + score;
//                    }
//                }

//            }


//            sb.AppendLine(DP[availableTime].ToString());
//        }

//        Console.WriteLine(sb.ToString());


//    }

//}
