//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;


////https://school.programmers.co.kr/learn/courses/30/lessons/42898
//class P_42898
//{
//    int solution(int m, int n, int[][] puddles)
//    {
//        List<List<int>> list = new List<List<int>>();

//        int DIVISION = 1_000_000_007;

//        //puddles를 효율적으로 탐색하고 저장하는 방법
//        //bool[,] puddleMap = new bool[m + 1, n + 1]; //1안
//        HashSet<(int, int)> puddleCoordinates = new HashSet<(int, int)>(); //2안


//        for(int i=0; i<puddles.Length;i++)
//        {
//            (int row, int col) coordinate = (puddles[i][0], puddles[i][1]);
//            puddleCoordinates.Add(coordinate);
//        }

//        int[][] DP = new int[m + 1][];
//        for (int i = 0; i < DP.Length; i++)
//        {
//            DP[i] = new int[n + 1];
//        }
//        DP[0][1] = 1;

//        for (int row = 1; row < DP.Length; row++)
//        {
//            for (int col = 1; col < DP[row].Length; col++)
//            {

//                if (puddleCoordinates.Contains((row,col)))
//                {
//                    continue;
//                }

//                int previousRow = DP[row - 1][col];
//                int previousCol = DP[row][col - 1];
//                DP[row][col] = (previousRow + previousCol) % DIVISION;
//            }
//        }


//        int answer = DP[m][n];

//        return answer;
//    }

//    static void Main()
//    {
//        var test = new P_42898();
//        int[][] puddles = new int[1][];
//        for (int i = 0; i < puddles.Length; i++)
//        {
//            puddles[i] = new int[2];
//        }
//        puddles[0][0] = 2;
//        puddles[0][1] = 2;


//        var result = test.solution(3, 4, puddles);
//        Console.WriteLine(result);
//    }
//}
