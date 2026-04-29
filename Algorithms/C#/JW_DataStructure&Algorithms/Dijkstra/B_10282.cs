//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Text;

////https://www.acmicpc.net/problem/10282
//class B_10282
//{
//    static void Main()
//    {
////        string test = @"2
////3 2 2
////2 1 5
////3 2 5
////3 3 1
////2 1 2
////3 1 8
////3 2 4";

////        Console.SetIn(new StringReader(test));

//        int count = int.Parse(Console.ReadLine());

//        while (count-- > 0)
//        {

//            int[] input =Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//            int n = input[0];
//            int d = input[1];
//            int c = input[2];

//            var map = new List<(int, int)>[n+1];
//            for (int i = 0; i < map.Length; i++)
//            {
//                map[i] = new List<(int, int)>();
//            }


//            for (int i=0; i<d; i++)
//            {
//                int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//                int a = info[0];
//                int b = info[1];
//                int s = info[2];

//                map[b].Add((a, s));

//                //역방향 그래프로 만들어야함 >> c가 감염되면 c를 참고하고있던 컴퓨터들이 감염되는거라
//            }

//            int[] dist = new int[n+1]; //dist 는 모두 0으로 초기화d
//            Array.Fill(dist, int.MaxValue);
//            dist[c] = 0;

//            var pq = new PriorityQueue<int, int>();
//            pq.Enqueue(c, 0);

//            while (pq.Count > 0)
//            {
//                pq.TryDequeue(out var curLoc, out int curCost);

//                if (curCost > dist[curLoc]) continue;

//                foreach (var next in map[curLoc])
//                {
//                    int nextTarget = next.Item1;
//                    int nextCost = next.Item2;

//                    //nextTarget != c 조건은 다시 시작점으로 돌아오는것 막기위한 조건
//                    if (nextCost + curCost < dist[nextTarget]) 
//                    {
//                        dist[nextTarget] = nextCost + curCost;
//                        pq.Enqueue(nextTarget, nextCost + curCost);
//                    }
//                }

//            }

//            //결국 감염된 컴퓨터만 cost 값이 있을꺼고 이 중 최댓값이 감염되기 까지의 시간이라 볼 수 있으며
//            //시간이 기록되었다는건 의존한 컴퓨터라 정의할 수 있으니 dist[i] 값이 0보다 크다면 무조건 감염된 컴퓨터로 카운트한다는 것

//            int infectedCount = 0;
//            int max = 0;
//            for (int i = 0; i < dist.Length; i++)
//            {
//                if (dist[i] != int.MaxValue)
//                {
//                    infectedCount++;
//                    max = Math.Max(max, dist[i]);
//                }
//            }

//            Console.WriteLine($"{infectedCount} {max}");

//        }
//    }


//}
