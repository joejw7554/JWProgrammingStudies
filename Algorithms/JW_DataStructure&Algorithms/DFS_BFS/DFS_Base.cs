//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography;
//using System.Text;


//class DFS_Base
//{
//    static bool[] visited = new bool[10];

//    static List<int>[] graph = new List<int>[10];



//    static void DFS(int current)
//    {
//        if (visited[current]) return;

//        visited[current] = true;
//        Console.WriteLine(current);

//        foreach (var next in graph[current])
//        {
//            if (visited[next] == false)
//            {
//                DFS(next);
//            }
//        }
//    }


//    static void Main()
//    {
//        for (int i = 0; i < graph.Length; i++) graph[i] = new List<int>();

//        graph[1].Add(3);
//        graph[1].Add(2);

//        graph[2].Add(3);


//        DFS(1);

//    }


//}
