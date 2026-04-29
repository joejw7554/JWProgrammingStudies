//using System;
//using System.Collections.Generic;
//using System.Text;

////https://www.acmicpc.net/problem/1446
//class B_1446
//{
//    static void Main()
//    {
//        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//        int N = input[0];
//        int destination = input[1];

//        List<(int, int)>[] road = new List<(int, int)>[destination + 1];
//        int[] dist = new int[destination + 1];
//        Array.Fill(dist, int.MaxValue);

//        for (int i = 0; i <= destination; i++)
//        {
//            road[i] = new List<(int, int)>();
//            if(i<destination)
//            road[i].Add((i + 1, 1));
//        }

//        for (int i = 0; i < N; i++)
//        {
//            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//            int start = input2[0];
//            int end = input2[1];
//            int cost = input2[2];

//            if(start<=destination && end <=destination)
//            road[start].Add((end, cost));
//        }

//        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

//        dist[0] = 0;
//        pq.Enqueue(0, 0);

//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out int curLocation, out int curCost);

//            if (dist[curLocation] < curCost) continue;

//            if (curLocation > destination) break;

//            foreach (var next in road[curLocation])
//            {
//                int target = next.Item1;
//                int cost = next.Item2;
//                if (curCost + cost < dist[target] && target <= destination)
//                {
//                    dist[target] = curCost + cost;
//                    pq.Enqueue(target, curCost + cost);
//                }
//            }
//        }

//        Console.WriteLine(dist[destination]);


//    }
//}
