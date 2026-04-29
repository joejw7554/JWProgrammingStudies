//using System;
//using System.Collections.Generic;

//public class DijkstraGuide
//{
//    // 노드 간의 거리를 나타낼 때 쓸 무한대 값 (연결 안 됨을 의미)
//    private const int INF = int.MaxValue;

//    public void Run()
//    {
//        int n = 8;

//        List<(int , int )>[] adj = new List<(int , int )>[n + 1];

//        for (int i = 0; i < adj.Length; i++)
//        {
//            adj[i] = new List<(int next, int cost)>();
//        }

//        // 예제 그래프: 8개 노드의 도시 연결망
//        // 1번 도시를 시작점으로 각 도시까지의 최단 경로 찾기

//        adj[1].Add((2, 2));   // 1 → 2 (비용 2)
//        adj[1].Add((3, 5));   // 1 → 3 (비용 5)
//        adj[1].Add((4, 1));   // 1 → 4 (비용 1))

//        adj[2].Add((3, 3));   // 2 → 3 (비용 3)
//        adj[2].Add((4, 2));   // 2 → 4 (비용 2))

//        adj[3].Add((5, 1));   // 3 → 5 (비용 1)
//        adj[3].Add((6, 5));   // 3 → 6 (비용 5))

//        adj[4].Add((3, 3));   // 4 → 3 (비용 3)
//        adj[4].Add((5, 1));   // 4 → 5 (비용 1))

//        adj[5].Add((6, 1));   // 5 → 6 (비용 1)
//        adj[5].Add((7, 4));   // 5 → 7 (비용 4))

//        adj[6].Add((7, 2));   // 6 → 7 (비용 2)
//        adj[6].Add((8, 3));   // 6 → 8 (비용 3))

//        adj[7].Add((8, 2));   // 7 → 8 (비용 2)

//        int[] result = SolveDijkstra(1, n, adj);

//        for (int i = 1; i < result.Length; i++)
//        {
//            Console.WriteLine($"{i}번쨰 비용: {result[i]}");
//        }
//    }

//    public int[] SolveDijkstra(int start, int n, List<(int target, int cost)>[] adj)
//    {
//        //최소 거리를 저장하는 배열 생성 후 최댓값으로 초기화 
//        int[] dist = new int[n + 1];
//        Array.Fill(dist, int.MaxValue);

//        //Start부분 0으로 초기화 이후 우선순위 Queue 에 시작 삽입
//        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
//        dist[start] = 0;

//        // dist 에 등록 이후 큐에 집어넣기
//        pq.Enqueue(start, 0);

//        //반복문으로 우선순위큐가 0이 될때까지 반복
//        while (pq.Count > 0)
//        {

//            //꺼낸 현재 노드 위치와 누적 비용 꺼내기
//            pq.TryDequeue(out int currentNode, out int currentCost);

//            //꺼낸 노드의 비용이 Dist 이전에 등록된 최소보다 크면 비교할 가치없으니 스킵
//            if (dist[currentNode] < currentCost) continue;


//            foreach ((int next, int cost) node in adj[currentNode])
//            {
//                int next = node.next;
//                int cost = node.cost;

//                //현재까지 누적 비용 + 다음 비용을 더해서 dist에 기록된 next보다 작다면 갱신
//                if (currentCost + cost < dist[next])
//                {
//                    dist[next] = currentCost + cost;
//                    pq.Enqueue(next, currentCost + cost);
//                }
//            }
//        }

//        return dist;
//    }

//    public static void Main()
//    {
//        new DijkstraGuide().Run();
//    }
//}