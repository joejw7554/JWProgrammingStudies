using System;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/18352
class B_18352
{
    static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int N = inputs[0];
        int M = inputs[1];
        int target = inputs[2];
        int begin = inputs[3];

        List<int>[] nodes = new List<int>[N + 1];

        for (int i = 1; i < N + 1; i++)
            nodes[i] = new List<int>();


        for (int i = 0; i < M; i++)
        {
            int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int from = info[0];
            int to = info[1];
            nodes[from].Add(to);
        }


        int[] dist = new int[N + 1];
        Array.Fill(dist, int.MaxValue);
        dist[begin] = 0;

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(begin, 0);

        while (pq.Count > 0)
        {
            pq.TryDequeue(out int currentLoc, out int cost);

            if (dist[currentLoc] < cost) continue;

            foreach (var adj in nodes[currentLoc])
            {
                if (cost + 1 < dist[adj])
                {
                    dist[adj] = cost + 1;
                    pq.Enqueue(adj, cost + 1);
                }

            }
        }


        List<int> result = new List<int>();
        for (int i = 1; i < dist.Length; i++)
        {
            if (dist[i] == target)
            {
                result.Add(i);
            }
        }

        if (result.Count == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }



    }
}