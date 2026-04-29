//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Text;

////https://www.acmicpc.net/problem/1238

//class B_1238
//{
//    static void Main()
//    {
////        // 테스트 입력 데이터
////        string testInput = @"4 8 2
////1 2 4
////1 3 2
////1 4 7
////2 1 1
////2 3 5
////3 1 2
////3 4 4
////4 2 3";

////        Console.SetIn(new StringReader(testInput));
////        // 테스트 끝나면 주석 처리하고 제출

//        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//        int N = input[0];
//        int M = input[1];
//        int X = input[2];

//        List<(int, int)>[] Nodes = new List<(int, int)>[N + 1];
//        List<(int, int)>[] revNodes = new List<(int, int)>[N + 1];


//        for (int i = 1; i <= N; i++)
//        {
//            Nodes[i] = new List<(int, int)>();
//            revNodes[i]= new List<(int, int)>();
//        }

//        for (int i = 0; i < M; i++)
//        {
//            int[] Node = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            int from = Node[0];
//            int to = Node[1];
//            int cost = Node[2];

//            Nodes[from].Add((to, cost));
//            revNodes[to].Add((from, cost));
//        }

//        int[] record = new int[N + 1];
//        int[] dist = new int[N + 1];
//        int start = X;

//        int[] distReturn = Dijkstra(Nodes, start);
//        int[] distGo = Dijkstra(revNodes, start);

//        int max = 0;

//        for (int i = 1; i <= N; i++)
//        {
//            max= Math.Max(max, distReturn[i] + distGo[i]);
//        }

//        Console.WriteLine(max);

//    }

//    private static int[] Dijkstra(List<(int, int)>[] Nodes, int start)
//    {
//        int[] dist = new int[Nodes.Length];
//        Array.Fill(dist, int.MaxValue);
//        dist[start] = 0;

//        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
//        pq.Enqueue(start, 0);

//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out int curLocation, out int curCost);

//            if (dist[curLocation] < curCost) continue;

//            foreach ((int, int) next in Nodes[curLocation])
//            {
//                int target = next.Item1;
//                int cost = next.Item2;

//                if (dist[target] > cost + curCost)
//                {
//                    dist[target] = cost + curCost;
//                    pq.Enqueue(target, cost + curCost);
//                }
//            }
//        }

//        return dist;
//    }
//}
