//using System;
//using System.Collections.Generic;
//using System.Linq;

////https://school.programmers.co.kr/learn/courses/30/lessons/43164?language=csharp
//public class Solution
//{
//    List<string> result;

//    public string[] solution(string[,] tickets)
//    {
//        // Dictionary로 그래프 구성
//        result = new List<string>();
//        var graph = new Dictionary<string, List<string>>();
        
//        for (int i = 0; i < tickets.GetLength(0); i++)
//        {
//            string from = tickets[i, 0];
//            string to = tickets[i, 1];
            
//            if (!graph.ContainsKey(from))
//                graph[from] = new List<string>();
            
//            graph[from].Add(to);
//        }
        
//        // 각 출발지별로 도착지 내림차순 정렬 (스택이므로)
//        foreach (var key in graph.Keys)
//        {
//            graph[key].Sort((a, b) => b.CompareTo(a));  // 역순!
//        }
        
//        DFS("ICN", graph);
        
//        result.Reverse();  // 역순으로 쌓였으므로
//        return result.ToArray();
//    }
    
//    void DFS(string airport, Dictionary<string, List<string>> graph)
//    {
//        if (graph.ContainsKey(airport))
//        {
//            while (graph[airport].Count > 0)
//            {
//                // 마지막 요소 (알파벳 순서 첫 번째) 꺼내기
//                string next = graph[airport][graph[airport].Count - 1];
//                graph[airport].RemoveAt(graph[airport].Count - 1);
                
//                DFS(next, graph);
//            }
//        }
        
//        result.Add(airport);  // 더 이상 갈 곳 없을 때 추가
//    }
    
//    static void Main(string[] args)
//    {
//        Solution sol = new Solution();

//        // 테스트 케이스 1: 기본 경로 (예상 결과: ["ICN", "JFK", "HND", "IAD"])
//        string[,] tickets1 = { { "ICN", "JFK" }, { "HND", "IAD" }, { "JFK", "HND" } };
//        Console.WriteLine($"Test 1: [{string.Join(", ", sol.solution(tickets1))}]");
//        // 예상: ICN → JFK → HND → IAD

//        // 테스트 케이스 2: 알파벳 순서 선택 (예상 결과: ["ICN", "ATL", "ICN", "SFO", "ATL", "SFO"])
//        string[,] tickets2 = { { "ICN", "SFO" }, { "ICN", "ATL" }, { "SFO", "ATL" }, { "ATL", "ICN" }, { "ATL", "SFO" } };
//        Console.WriteLine($"Test 2: [{string.Join(", ", sol.solution(tickets2))}]");
//        // 예상: ICN → ATL → ICN → SFO → ATL → SFO

//        // 테스트 케이스 3: 백트래킹 필요 (예상 결과: ["ICN", "BBB", "ICN", "AAA"])
//        // 처음에 AAA를 선택하면 막다른 길, BBB를 먼저 가야 함
//        string[,] tickets3 = { { "ICN", "AAA" }, { "ICN", "BBB" }, { "BBB", "ICN" } };
//        Console.WriteLine($"Test 3: [{string.Join(", ", sol.solution(tickets3))}]");
//        // 예상: ICN → BBB → ICN → AAA (알파벳순으로 AAA가 먼저지만 그러면 티켓 1개 남음)

//        // 테스트 케이스 4: 단순 경로 (예상 결과: ["ICN", "A", "B", "C"])
//        string[,] tickets4 = { { "ICN", "A" }, { "A", "B" }, { "B", "C" } };
//        Console.WriteLine($"Test 4: [{string.Join(", ", sol.solution(tickets4))}]");

//        // 테스트 케이스 5: 같은 공항 여러 번 방문 (예상 결과: ["ICN", "AAA", "ICN", "AAA", "ICN"])
//        string[,] tickets5 = { { "ICN", "AAA" }, { "AAA", "ICN" }, { "ICN", "AAA" }, { "AAA", "ICN" } };
//        Console.WriteLine($"Test 5: [{string.Join(", ", sol.solution(tickets5))}]");
//    }
//}