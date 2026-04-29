//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Text;


////https://www.acmicpc.net/problem/4485

//class B_4485
//{

//    static bool CheckBoundary(int row, int col, int N)
//    {
//        return row >= 0 && row < N && col >= 0 && col < N;
//    }

//    static void Main()
//    {
////        string testInput =
////        @"3
////5 5 4
////3 9 1
////3 2 7
////5
////3 7 2 0 1
////2 8 0 9 1
////1 2 1 8 1
////9 8 9 2 0
////3 6 5 1 5
////7
////9 0 5 1 1 5 3
////4 1 2 1 6 5 3
////0 7 6 1 6 8 5
////1 1 7 8 3 2 3
////9 4 0 7 6 4 1
////5 8 3 2 4 8 3
////7 4 8 4 8 3 4
////0";
////        Console.SetIn(new StringReader(testInput));


//        int N;
//        int[] dRow = new int[] { 0, 1, 0, -1 };
//        int[] dCol = new int[] { 1, 0, -1, 0 };
//        int count = 0;

//        while ((N = int.Parse(Console.ReadLine())) != 0)
//        {
//            count++;

//            int[,] map = new int[N, N];

//            for (int i = 0; i < N; i++)
//            {
//                int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//                for (int j = 0; j < N; j++)
//                {
//                    map[i, j] = row[j];
//                }
//            }

//            int[][] dist = new int[N][];
//            for (int i = 0; i < N; i++)
//            {
//                dist[i] = new int[N];
//                Array.Fill(dist[i], int.MaxValue);
//            }

//            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
//            dist[0][0] = map[0, 0];
//            pq.Enqueue((0, 0), dist[0][0]);


//            while (pq.Count > 0)
//            {
//                pq.TryDequeue(out (int row, int col) current, out int curCost);

//                if (current.row == N - 1 && current.col == N - 1)
//                {
//                    // curCost가 목적지까지의 최단 거리!
//                    Console.WriteLine($"Problem {count}: {curCost}");
//                    break;  // 더 탐색할 필요 없음
//                }

//                if (dist[current.row][current.col] < curCost) continue;

//                for (int i = 0; i < 4; i++)
//                {
//                    int nextRow = current.row + dRow[i];
//                    int nextCol = current.col + dCol[i];

//                    if (CheckBoundary(nextRow, nextCol, N)) //오른쪽 아래 왼쪽 위 차례대로
//                    {
//                        int nextCost = curCost + map[nextRow, nextCol];
//                        if (nextCost < dist[nextRow][nextCol])
//                        {
//                            dist[nextRow][nextCol] = nextCost;
//                            pq.Enqueue((nextRow, nextCol), nextCost);
//                        }
//                    }
//                }
//            }
//        }



//    }

//}


