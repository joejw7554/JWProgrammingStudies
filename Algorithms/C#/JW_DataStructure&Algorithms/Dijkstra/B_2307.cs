//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Runtime.InteropServices;
//using System.Text;

////https://www.acmicpc.net/problem/2307
//class B_2307
//{
//    static void Main()
//    {
//        string test1 = @"6 7
//1 2 1
//1 4 3
//3 6 1
//4 5 1
//2 3 2
//3 4 1
//5 6 2";

//        string test2 = @"8 11
//1 2 1
//1 5 8
//1 7 9
//2 5 2
//3 4 4
//3 6 3
//3 8 5
//4 6 10
//4 8 11
//5 6 6
//5 7 7";

//        Console.SetIn(new StringReader(test2));

//        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//        int N = input[0];
//        int M = input[1];


//        var map = new List<(int, int)>[N + 1];

//        for (int i = 0; i < map.Length; i++)
//        {
//            map[i] = new List<(int, int)>();
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

//        int[] parents;
//        int minCost = GetShortestPath(N, map, out parents);

//        int curr = N;
//        List<(int, int)> blockedList = new List<(int, int)>();
//        while (curr != 0 && curr != 1)
//        {
//            int prev = parents[curr];

//            blockedList.Add((prev, curr));
//            curr = prev;
//        }

//        int maxCost = 0;
//        foreach ((int from, int to) blocked in blockedList)
//        {
//            int result = GetShortestPath(N, map, out _, blocked.from, blocked.to);

//            if(result==int.MaxValue)
//            {
//                maxCost = int.MaxValue;
//                break;
//            }

//            maxCost = Math.Max(maxCost, result);
//        }

//        if (maxCost == minCost)
//        {
//            Console.WriteLine(0);
//        }
//        else if (maxCost == int.MaxValue)
//        {
//            Console.WriteLine(-1);
//        }
//        else
//        {
//            Console.WriteLine(maxCost - minCost);
//        }

//    }

//    private static int GetShortestPath(int N, List<(int, int)>[] map, out int[] parents, int bFrom = -1, int bTo = -1)
//    {
//        parents = new int[N + 1];

//        int[] dist = new int[N + 1];
//        PriorityQueue<int, int> pq;

//        dist = new int[N + 1];
//        Array.Fill(dist, int.MaxValue);
//        dist[1] = 0;

//        pq = new PriorityQueue<int, int>();
//        pq.Enqueue(1, 0);

//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out int curLocation, out int curCost);

//            if (curCost > dist[curLocation]) continue;

//            foreach (var next in map[curLocation])
//            {
//                int nextTarget = next.Item1;
//                int nextCost = next.Item2;

//                int totalCost = curCost + nextCost;

//                if ((nextTarget == bTo && curLocation == bFrom) || (nextTarget == bFrom && curLocation == bTo)) continue;

//                if (totalCost < dist[nextTarget])
//                {
//                    parents[nextTarget] = curLocation;
//                    dist[nextTarget] = totalCost;
//                    pq.Enqueue(nextTarget, totalCost);
//                }
//            }
//        }

//        return dist[N];
//    }
//}
