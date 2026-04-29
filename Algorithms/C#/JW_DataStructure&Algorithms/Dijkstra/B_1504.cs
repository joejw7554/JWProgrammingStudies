//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Numerics;
//using System.Text;


////https://www.acmicpc.net/problem/1504

//class B_1504
//{
//    static void Main()
//    {

//        TextReader reader;

//#if DEBUG
//        // 로컬 디버깅 모드일 때는 문자열에서 읽기
//        string test = @"4 6
//1 2 3
//2 3 3
//3 4 1
//1 3 5
//2 4 5
//1 4 4
//2 3";
//        reader = new StringReader(test);
//#else
//    // 실제 제출(Release) 모드일 때는 표준 입력에서 읽기
//    reader = new StreamReader(Console.OpenStandardInput());
//#endif

//        // 이후 모든 읽기는 sr 대신 reader를 사용
//        int[] input = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);
//        int N = input[0];
//        int E = input[1];

//        var map = new List<(int, int)>[N + 1];
//        for (int i = 0; i < map.Length; i++)
//        {
//            map[i] = new List<(int, int)>();
//        }

//        //지도 정보
//        for (int i = 0; i < E; i++)
//        {
//            int[] info = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);
//            int from = info[0];
//            int to = info[1];
//            int cost = info[2];

//            map[from].Add((to, cost));
//            map[to].Add((from, cost));
//        }

//        //지나야하는 노드 리스트
//        int[] required = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);

//        int v1 = required[0];
//        int v2 = required[1];

//        int[] dFromStart = Dijkstra(map, N, 1);
//        int[] dFromV1 = Dijkstra(map, N, v1);
//        int[] dFromV2 = Dijkstra(map, N, v2);

//        long path1 = (long)dFromStart[v1] + dFromV1[v2] + dFromV2[N];
//        long path2 = (long)dFromStart[v2] + dFromV2[v1] + dFromV1[N];

//        long result = Math.Min(path1, path2);

//        if (result >= int.MaxValue)
//        {
//            Console.WriteLine(-1);
//        }
//        else
//        {
//            Console.WriteLine(result);

//        }
//    }

//    static int[] Dijkstra(List<(int, int)>[] map, int N, int start)
//    {
//        int[] dist = new int[N + 1];
//        Array.Fill(dist, int.MaxValue);

//        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
//        dist[start] = 0;
//        pq.Enqueue(start, 0);

//        while (pq.Count > 0)
//        {
//            pq.TryDequeue(out int curLocation, out int curCost);

//            if (curCost > dist[curLocation]) continue;

//            foreach (var next in map[curLocation])
//            {
//                int nextTarget = next.Item1;
//                int nextCost = next.Item2;

//                int totalCost = nextCost + curCost;

//                if (totalCost < dist[nextTarget])
//                {
//                    dist[nextTarget] = totalCost;
//                    pq.Enqueue(nextTarget, totalCost);
//                }

//            }
//        }


//        return dist;
//    }

//}
