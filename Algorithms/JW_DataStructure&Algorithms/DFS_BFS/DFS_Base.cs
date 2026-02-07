using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


class DFS_Base
{
    static bool[] visited = new bool[10];

    static List<int>[] graph = new List<int>[10];

    static Stack<int> VisitOrder = new Stack<int>();



    static void DFS(int start)
    {
        visited[start] = true;
        VisitOrder.Push(start);

        while (VisitOrder.Count > 0)
        {
            if (VisitOrder.TryPop(out int current))
            {

                //visited[current] = true;


                for (int i = graph[current].Count - 1; i >= 0; i--)
                {
                    var nextNode = graph[current][i];
                    if (visited[nextNode] == false)
                    {
                        visited[nextNode] = true;
                        VisitOrder.Push(nextNode);

                        Console.WriteLine("Push: " + nextNode);
                    }
                }
            }
        }

    }


    static void Main()
    {
        for (int i = 0; i < graph.Length; i++) graph[i] = new List<int>();

        graph[1].Add(2);
        graph[1].Add(3);

        graph[2].Add(3);


        DFS(1);

    }


}
