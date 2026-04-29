//using System;
//using System.Collections.Generic;
//using System.Text;

////https://www.acmicpc.net/problem/1162
//class B_1162_R
//{
//    static void Main()
//    {

//        string testInput = @"4 4 1
//1 2 10
//2 4 10
//1 3 1
//3 4 100";
//        Console.SetIn(new StringReader(testInput));

//        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//        int N = input[0];
//        int M = input[1];
//        int K = input[2];


//        List<(int target, long cost)>[] map = new List<(int target, long cost)>[N + 1];

//        for (int i = 0; i < map.Length; i++)
//        {
//            map[i] = new List<(int, long)>();
//        }

//        for (int i = 0; i < M; i++)
//        {
//            int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            int from = info[0];
//            int to = info[1];
//            int cost = info[2];

//            map[from].Add((to, cost));
//            map[to].Add((from, cost));

//        }

//        Dijkstra(N, K, map);

//    }

//    private static void Dijkstra(int N, int K, List<(int target, long cost)>[] map)
//    {
//        long[][] dist = new long[N + 1][];
//        for (int i = 0; i < dist.Length; i++)
//        {
//            dist[i] = new long[K + 1];
//            Array.Fill(dist[i], long.MaxValue);
//        }

//        var pq = new PriorityQueue<(int, int), long>();
//        dist[1][0] = 0;
//        pq.Enqueue((1, 0), 0);

//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out (int, int) element, out long curCost);
//            var (curLocation, usedChance) = element;

//            if (dist[curLocation][usedChance] < curCost) continue;

//            foreach (var next in map[curLocation])
//            {
//                if (dist[next.target][usedChance] > curCost + next.cost)
//                {
//                    pq.Enqueue((next.target, usedChance), curCost + next.cost);
//                    dist[next.target][usedChance] = curCost + next.cost;
//                }

//                if (usedChance < K && dist[next.target][usedChance + 1] > curCost)
//                {
//                    pq.Enqueue((next.target, usedChance + 1), curCost);
//                    dist[next.target][usedChance + 1] = curCost;
//                }
//            }

//        }


//        long answer = long.MaxValue;

//        for (int i = 0; i < dist[N].Length; i++)
//        {
//            answer = Math.Min(dist[N][i], answer);
//        }

//        Console.WriteLine(answer);
//    }


//}
