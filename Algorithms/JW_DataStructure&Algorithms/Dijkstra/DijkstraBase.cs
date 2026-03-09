using System;
using System.Collections.Generic;

public class DijkstraGuide
{
    // 노드 간의 거리를 나타낼 때 쓸 무한대 값 (연결 안 됨을 의미)
    private const int INF = int.MaxValue;

    public void Run()
    {
        int n = 5; // 지점(노드)의 개수

        // 인접 리스트(Adjacency List) 구조:
        // 배열의 인덱스 [i]는 '출발 노드 번호'를 의미하며,
        // 그 내부의 List는 해당 노드에서 갈 수 있는 '목적지와 비용'의 집합입니다.
        List<(int target, int cost)>[] adj = new List<(int, int)>[n + 1];

        // 각 배열의 방마다 실제 리스트 객체를 생성해줍니다.
        for (int i = 0; i <= n; i++) adj[i] = new List<(int, int)>();

        // 길 정보 추가 (1번에서 2번까지 비용 10 등...)
        // adj[1]이라는 리스트에 (2, 10)이라는 튜플 데이터를 추가하는 방식입니다.
        adj[1].Add((2, 10));
        adj[1].Add((3, 5));
        adj[2].Add((4, 1));
        adj[3].Add((2, 3));
        adj[3].Add((4, 9));
        adj[3].Add((5, 2));
        adj[4].Add((5, 4));
        adj[5].Add((1, 7));

        // 1번 지점에서 출발했을 때 각 지점까지의 최단 거리 계산
        int[] result = SolveDijkstra(1, n, adj);

        Console.WriteLine("=== 1번 지점 기준 최단 거리 결과 ===");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}번 지점까지의 거리: {(result[i] == INF ? "못 감" : result[i].ToString())}");
        }
    }

    public int[] SolveDijkstra(int start, int n, List<(int target, int cost)>[] adj)
    {
        // 각 노드까지의 최단 거리를 저장할 배열 (인덱스 = 노드 번호)
        int[] dist = new int[n + 1];
        
        // 모든 노드의 거리를 무한대로 초기화 (아직 방문 안 함)
        Array.Fill(dist, int.MaxValue);

        // 우선순위 큐: (노드 번호, 거리)를 저장, 거리가 작은 것부터 나옴
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        
        // 시작 노드의 거리는 0 (자기 자신까지의 거리)
        dist[start] = 0;
        
        // 시작 노드를 큐에 삽입 (노드: start, 우선순위: 0)
        pq.Enqueue(start, 0);

        // 큐가 빌 때까지 반복 (모든 도달 가능한 노드 탐색)
        while (pq.Count > 0)
        {
            // 현재 처리할 노드와 그 노드까지의 누적 비용을 꺼냄
            pq.TryDequeue(out int currNode, out int curCost);

            // 이미 더 짧은 경로를 발견했다면 스킵 (중복 처리 방지)
            // 큐에 같은 노드가 여러 번 들어갈 수 있으므로 필터링
            if (curCost > dist[currNode]) continue;

            // 현재 노드에서 갈 수 있는 모든 인접 노드 확인
            foreach (var next in adj[currNode])
            {
                // 다음 노드 번호
                int nextNode = next.target;
                
                // 현재 노드에서 다음 노드로 가는 비용
                int cost = next.cost;

                // 현재 경로(curCost + cost)가 기존 최단 거리보다 짧으면 갱신
                if (curCost + cost < dist[nextNode])
                {
                    // 새로운 최단 거리로 업데이트
                    dist[nextNode] = curCost + cost;
                    
                    // 갱신된 거리로 다음 노드를 큐에 추가 (탐색 계속)
                    pq.Enqueue(nextNode, cost + curCost);
                }
            }
        }

        // 시작 노드부터 각 노드까지의 최단 거리 배열 반환
        return dist;
    }

    public static void Main()
    {
        new DijkstraGuide().Run();
    }
}