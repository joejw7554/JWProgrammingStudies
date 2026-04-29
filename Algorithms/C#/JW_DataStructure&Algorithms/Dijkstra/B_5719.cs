//using System;
//using System.Collections.Generic;
//using System.Text;
//using static System.Net.Mime.MediaTypeNames;

////https://www.acmicpc.net/problem/5719
//class B_5719
//{
//    static void Main()
//    {
////        string testInput =
////            @"7 9
////0 6
////0 1 1
////0 2 1
////0 3 2
////0 4 3
////1 5 2
////2 6 4
////3 6 2
////4 6 4
////5 6 1
////4 6
////0 2
////0 1 1
////1 2 1
////1 3 1
////3 2 1
////2 0 3
////3 0 2
////6 8
////0 1
////0 1 1
////0 2 2
////0 3 3
////2 5 3
////3 4 2
////4 1 1
////5 1 1
////3 0 1
////0 0";
////        Console.SetIn(new StringReader(testInput));

//        while (true)
//        {
//            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            if (input[0] == 0) break;

//            int NodeNum = input[0];
//            int EdgeNum = input[1];

//            List<(int, int)>[] map = new List<(int, int)>[NodeNum];

//            int[] init = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            int start = init[0];
//            int destination = init[1];


//            for (int i = 0; i < NodeNum; i++)
//            {
//                map[i] = new List<(int, int)>();
//            }

//            for (int i = 0; i < EdgeNum; i++)
//            {
//                int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//                int from = info[0];
//                int to = info[1];
//                int cost = info[2];

//                map[from].Add((to, cost));
//            }

//            Dijkstra(start, destination, map, NodeNum);
//        }
//    }

//    static void Dijkstra(int start, int destination, List<(int, int)>[] map, int nodeNum)
//    {
//        //최단 거리 구하기
//        int[] dist = new int[nodeNum];
//        List<int>[] parent = new List<int>[nodeNum];
//        for(int i=0; i< parent.Length; i++)
//            parent[i] = new List<int>();

//        Array.Fill(dist, int.MaxValue);

//        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
//        dist[start] = 0;
//        pq.Enqueue(start, dist[start]);


//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out int curLocation, out int curCost);


//            if (curCost > dist[curLocation]) continue;

//            foreach ((int target, int cost) next in map[curLocation])
//            {
//                if (next.cost + curCost < dist[next.target])
//                {
//                    dist[next.target] = next.cost + curCost;
//                    parent[next.target].Clear();
//                    parent[next.target].Add(curLocation);
//                    pq.Enqueue(next.target, next.cost + curCost);

//                }
//                else if (next.cost + curCost == dist[next.target])
//                {
//                    parent[next.target].Add(curLocation);
//                }
//            }
//        }


//        //제거해야할 경로들 파악
//        Queue<int> track = new Queue<int>();
//        bool[,] isRemoved = new bool[nodeNum, nodeNum];
//        bool[] visited = new bool[nodeNum];
//        visited[destination] = true;
//        track.Enqueue(destination);

//        while (track.Count > 0)
//        {
//            track.TryDequeue(out int curLocation);

//            if (curLocation == start) continue;

//            foreach (var parentNode in parent[curLocation])
//            {
//                isRemoved[parentNode, curLocation] = true;

//                if (visited[parentNode]==false)
//                {
//                    visited[parentNode] = true;
//                    track.Enqueue(parentNode);
//                }
//            }
//        }


//        //다시 다익스트라
//        dist = new int[nodeNum];
//        parent = new List<int>[nodeNum];
//        Array.Fill(dist, int.MaxValue);

//        pq = new PriorityQueue<int, int>();
//        dist[start] = 0;
//        pq.Enqueue(start, dist[start]);


//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out int curLocation, out int curCost);

//            if (curCost > dist[curLocation]) continue;

//            foreach ((int target, int cost) next in map[curLocation])
//            {
//                if (isRemoved[curLocation, next.target] == true) continue;

//                if (next.cost + curCost < dist[next.target])
//                {
//                    dist[next.target] = next.cost + curCost;
//                    pq.Enqueue(next.target, next.cost + curCost);
//                }
//            }
//        }

//        if (dist[destination] == int.MaxValue)
//        {
//            Console.WriteLine(-1);
//        }
//        else
//        {
//            Console.WriteLine(dist[destination]);
//        }
//    }
//}
