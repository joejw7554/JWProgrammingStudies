using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


//https://school.programmers.co.kr/learn/courses/30/lessons/86971

class P_86971
{
    public int solution(int n, int[,] wires)
    {

        //끊어서 2개로 분할한다는게 코드로는 어떤의미이지?

        //백트랙킹은 필요할꺼같은데 과정 로직은 어떻게 짜야할지 모르겠네

        //송전탑 개수의 차이를 비슷하게 맞춘다는거는 Min값을 구하라는것일꺼고...

        //저 2차원 배열을 어떻게 사용해야할까..

        //DFS를 써야하나? 끊는 과정을 어떻게 표현하며 프로그래밍 해야하지?

        //일단 그룹으로 나누어야되 무조건 2개 그룹밖에 안오잖아? 그럼 배열 2개로 따로구분해보자

        //끊는다는 의미는 결국 저 2차원 배열중 하나를 하나씩 없애고 그룹핑하면 그룹에 갯수를 구할수 있을꺼고
        //그다음 두개 그룹의 차이만큼 빼서 Min에다가 저장하면 될꺼같은데?

        //풀이 흐름
        //그러면 저 2차원 배열의 행을 모두 순회하는게 전체 루프일꺼고
        //그 과정에서 경로 하나씩 없애고 다시 그룹핑해야겠네?



        //그룹핑 끝나면 비교해서 Min값 기록하고

        //초기화하고 다음 반복문턴으로 진행해야겠네

        //더 간단한 흐름이 없을까?

        //다른 대안
        //경로 하나씩 없애보되 [i,1]과 연결된애들 갯수만 세면 되는거 아니야?

        //그럼 전체의 송전탑 갯수 - [i,1]과 연결된 갯수를 하면 나눈 B그룹의  갯수가 나올꺼고 A그룹은 전체 - B그룹 이될꺼고 |A-B| 절댓값하면 갯수 차이 나올꺼고
        //그것의 최솟값을 구하면되겠네

        //해법
        List<int>[] graph = new List<int>[n+1];

        for (int i = 1; i < graph.Length; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            int start = wires[i, 0];
            int end = wires[i, 1];

            graph[start].Add(end);
            graph[end].Add(start); 
        }

        int minDifference= int.MaxValue;

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            //이걸로 어떻게 찾아나가지?? 2차원 배열이라 까다롭네..IndexOf도 쓸수없고... => 직접 자료구조를 만들어서 정리하라 (해법)
            //int disconnectedPoint = wires[i, 1];

            int v1 = wires[i, 0];
            int v2 = wires[i, 1];

            bool[] visited = new bool[n + 1];
            int groupACount = GetNodeCountDFS(v1, v2, graph, visited);

            int groupBCount = n - groupACount;
            int diff = Math.Abs(groupACount - groupBCount);

            minDifference= Math.Min(minDifference, diff);
        }


        return minDifference;
    }

    int GetNodeCountDFS(int current, int blocked, List<int>[] graph, bool[] visited)
    {
        visited[current] = true;
        int count = 1;

        foreach (int next in graph[current])
        {
            if (next == blocked || visited[next]) continue;

            count += GetNodeCountDFS(next, blocked, graph, visited);
        }


        return count;
    }

    static void Main()
    {
        var test = new P_86971();
        var result = test.solution(9, new int[,] { { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 4, 6 }, { 4, 7 }, { 7, 8 }, { 7, 9 } });
        Console.WriteLine(result);

    }
}
