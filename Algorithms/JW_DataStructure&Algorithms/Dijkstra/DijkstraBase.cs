using System;
using System.Collections.Generic;

public class DijkstraBasic
{
    public void RunDijkstra()
    {
        int count = 10;

        List<(int target,int cost)>[] adj = new List<(int target, int cost)>[count+1];

        // adj 리스트 초기화 및 임의 데이터 추가
        for (int i = 0; i <= count; i++)
        {
            adj[i] = new List<(int target, int cost)>();
        }

        // 임의의 간선 추가
        adj[1].Add((2, 5));
        adj[1].Add((3, 3));
        adj[2].Add((3, 2));
        adj[2].Add((4, 6));
        adj[3].Add((4, 7));
        adj[3].Add((5, 4));
        adj[4].Add((5, 1));
        adj[4].Add((6, 8));
        adj[5].Add((6, 3));
        adj[6].Add((7, 2));
        adj[7].Add((8, 4));
        adj[8].Add((9, 1));
        adj[9].Add((10, 5));

        int[] result =CalculateDijkstra(1, count, adj);


        for(int i=1; i< adj.Length; i++)
        {
            Console.WriteLine($"Target:{i}, Cost:{result[i]}");
        }
    }

    public int[] CalculateDijkstra(int start, int count, List<(int target, int cost)>[] adj)
    {

        int[] map = new int[count+1];
        Array.Fill(map, int.MaxValue);

        var pq = new PriorityQueue<int , int>();
        map[start] = 0;
        pq.Enqueue(1, 0);
        while(pq.Count>0)
        {
            if (!pq.TryDequeue(out int currrentID, out int currentCost)) break;

            if (currentCost > map[currrentID]) continue;

            foreach (var node in adj[currrentID])
            {
                int nextID = node.target;
                int nextCost = node.cost+ currentCost;

                if (nextCost < map[nextID])
                {
                    pq.Enqueue(nextID, nextCost);
                    map[nextID] = nextCost;
                }

            }
        }

        return map;
    }

    public static void Main()
    {
        new DijkstraBasic().RunDijkstra();
    }
}