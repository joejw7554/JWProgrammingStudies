using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

//https://www.acmicpc.net/problem/10217
class B_10217
{
    static void Main()
    {
        //        string test1 = @"1
        //3 100 3
        //1 2 1 1
        //2 3 1 1
        //1 3 3 30";


        //        string test2 = @"1
        //4 10 4
        //1 2 5 3
        //2 3 5 4
        //3 4 1 5
        //1 3 10 6";

        //        Console.SetIn(new StringReader(test2));

        int T = int.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = input[0];
            int M = input[1];
            int K = input[2];


            List<(int, int, int)>[] map = new List<(int, int, int)>[N + 1];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = new List<(int, int, int)>();
            }

            for (int i = 0; i < K; i++)
            {
                int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                int U = info[0];
                int V = info[1];
                int C = info[2];
                int D = info[3];

                map[U].Add((V, C, D));
            }

            //시간(D), 자원(C)
            int[,] dist = new int[N + 1, M + 1];

            for (int i = 0; i < N + 1; i++)
            {
                for (int j = 0; j < M + 1; j++)
                {
                    dist[i, j] = int.MaxValue;
                }
            }


            var pq = new PriorityQueue<(int, int), int>();
            pq.Enqueue((1, 0), 0);
            dist[1, 0] = 0;

            while (pq.Count > 0)
            {
                pq.TryDequeue(out (int, int) element, out int curCost);
                (int curLoction, int curResource) = element;

                if (dist[curLoction, curResource] < curCost) continue;


                bool skip = false;
                for (int i = 0; i < curResource; i++)
                {
                    if (dist[curLoction, i] < curCost)
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip) continue;

                foreach (var next in map[curLoction])
                {
                    int target = next.Item1;
                    int resource = next.Item2;
                    int cost = next.Item3;

                    int totalCost = curCost + cost;
                    int totalResource = curResource + resource;

                    //시간이 더 적게 걸리면서 자원이 M 이하 사용했을때만 갱신
                    if (totalResource <= M && totalCost < dist[target, totalResource]) //적은 시간 + M이하의 자원이라면 
                    {
                        for (int i = totalResource; i < totalResource; i++)
                        {
                            if (dist[target, i] > totalCost)
                                dist[target, i] = totalCost;
                            else
                                break;
                        }
                        pq.Enqueue((target, totalResource), totalCost);
                    }
                }



            }

            int min = int.MaxValue;
            for (int i = 0; i < dist.GetLength(1); i++)
            {
                min = Math.Min(min, dist[N, i]);
            }

            if (min != int.MaxValue)
            {
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine("Poor KCM");
            }


        }
    }
}
