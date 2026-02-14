using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//https://school.programmers.co.kr/learn/courses/30/lessons/43162
public class Solution
{
    public int solution(int n, int[,] computers)
    {
        int answer = 0;
        bool[] visited = new bool[n];

        ////DFS (stack)
        //Stack<int> stack = new Stack<int>();

        //for (int i = 0; i < n; i++)
        //{
        //    if (visited[i] == false)
        //    {
        //        answer++;
        //        visited[i] = true;
        //        stack.Push(i);

        //        while (stack.Count > 0)
        //        {
        //            var k = stack.Pop();

        //            for (int j = 0; j < n; j++)
        //            {
        //                if (computers[k, j] == 1 && visited[j] == false)
        //                {
        //                    stack.Push(j);
        //                    visited[j] = true;
        //                }
        //            }

        //        }


        //    }
        //}


        //////////////////////////////////////////////////////
        //BFS

        //Queue<int> queue = new Queue<int>();

        //for(int i=0; i<n;i++)
        //{
        //    if(visited[i]==false)
        //    {
        //        queue.Enqueue(i);
        //        visited[i] = true;
        //        answer++;

        //        while(queue.Count>0)
        //        {
        //            var k= queue.Dequeue();

        //            for(int j=0; j<n;j++)
        //            {
        //                if (computers[k,j]==1 && visited[j]==false)
        //                {
        //                    queue.Enqueue(j);
        //                    visited[j] = true;
        //                }
        //            }

        //        }
        //    }
        //}

        ///////////////////////////////////////////////////
        //DFS (recursion)

        
        for (int i = 0; i < n; i++)
        {
            if (visited[i] == false)
            {
                answer++;
                Recursion(i, n, computers, visited);
            }
        }







        return answer;
    }


    static void Recursion(int k, int n, int[,]computers, bool[]visited)
    {
        if (visited[k] == true) return;

        visited[k] = true;

        for (int i = 0; i < n; i++)
        {
            if(visited[i]==false && computers[k,i]==1)
            {
                Recursion(i, n, computers, visited);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        // 테스트 케이스 1: 모두 연결된 경우 (네트워크 1개)
        int[,] test1 = {
            {1, 1, 0},
            {1, 1, 0},
            {0, 0, 1}
        };
        Console.WriteLine($"테스트 1: {sol.solution(3, test1)}  (예상: 2)");

        // 테스트 케이스 2: 모두 독립된 경우 (네트워크 3개)
        int[,] test2 = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };
        Console.WriteLine($"테스트 2: {sol.solution(3, test2)}  (예상: 3)");

        // 테스트 케이스 3: 간접 연결 (0-1-2-3 체인, 네트워크 1개)
        int[,] test3 = {
            {1, 1, 0, 0},
            {1, 1, 1, 1},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        Console.WriteLine($"테스트 3: {sol.solution(4, test3)}  (예상: 1)");
    }
}



