using System;
using System.Collections.Generic;
using System.Text;

//https://school.programmers.co.kr/learn/courses/30/lessons/87946?language=csharp
class P_87946
{
    public int solution(int k, int[,] dungeons)
    {

        //던전의 행의 갯수가 던전 존재 수인거니까 N이되는거지
        int n = dungeons.GetLength(0);
        //DFS + BackTracking 조합 문제

        //방문했는지 여부 체크해야겠네 중복 방지할려면?
        bool[] visited = new bool[n];

        //DFS 는 스택메모리 사용해서 재귀로하자



        //이거의 최대 경우의수는 n*(n-1)* (n-2) * .....*1 이겠네?
        int answer = DFS(visited, k, 0, dungeons, n);




        return answer;
    }

    int DFS(bool[] visited, int currentStat, int currentCount, int[,] dungeons, int n)
    {

        int max = currentCount;

        for (int i = 0; i < n; i++)
        {
            int requiredStat = dungeons[i, 0];

            //방문 안했고 현재 피로도가 최소 피로도이상이면 진행 
            if (!visited[i] && currentStat >= requiredStat)
            {
                //방문처리 + 카운트 증가
                visited[i] = true;

                int result = DFS(visited, currentStat - dungeons[i, 1], currentCount + 1, dungeons, n);

                //백트랙킹 -> 미방문처리 + 카운트감소
                max = Math.Max(max, result);

                visited[i] = false;
            }
        }


        //내가 구하고자하는건 최대 탐험 던전 수인데 이걸 어떻게 구하지...
        return max;

    }



    static void Main()
    {
        var test = new P_87946();
        var result = test.solution(80, new[,] { { 80, 20 }, { 50, 40 }, { 30, 10 } });

        Console.WriteLine(result);
    }
}
