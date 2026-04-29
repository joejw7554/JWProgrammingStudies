//using System;
//using System.Collections.Generic;
//using System.Data;
//public class P43163
//{
//    int minCount = int.MaxValue;
    
//    //https://school.programmers.co.kr/learn/courses/30/lessons/43163?language=csharp
//    public int solution(string begin, string target, string[] words)
//    {
//        minCount = int.MaxValue;
//        HashSet<string> visited = new HashSet<string>() { begin };

//        //BFS
//        var queue = new Queue<(string, int)>();

//        queue.Enqueue((begin, 0));


//        while (queue.Count > 0)
//        {
//            var (currentWord, count) = queue.Dequeue();

//            if (currentWord == target)
//            {
//                return count;
//            }


//            foreach (var word in words)
//            {
//                int diffCount = 0;

//                if (visited.Contains(word)) continue;

//                for (int i = 0; i < word.Length; i++)
//                {
//                    if (word[i] != currentWord[i])
//                        diffCount++;

//                    if (diffCount > 1) break;
//                }

//                if (diffCount == 1)
//                {
//                    visited.Add(word);
//                    queue.Enqueue((word, count + 1));
//                }
//            }

//        }

//        return 0;


//        ////DFS
//        //DFS_BackTracking(begin,target,words, visited, 0);


//        //if (minCount == int.MaxValue) minCount = 0;

//        //return minCount;
//    }

//    void DFS_BackTracking(string current, string target, string[] words, HashSet<string> visited, int count)
//    {
//        if (current == target)
//        {
//            minCount=int.Min(minCount, count);
//            return;
//        }

//        foreach (var word in words)
//        {
//            if (visited.Contains(word)) continue;

//            int diffCount = 0;
//            for (int i = 0; i < word.Length; i++)
//            {
//                if (current[i] != word[i]) diffCount++;

//                if (diffCount > 1) break;
//            }

//            if (diffCount == 1)
//            {
//                visited.Add(word);
//                DFS_BackTracking(word, target, words, visited, count + 1);
//                visited.Remove(word);
//            }
//        }


//    }
//        static void Main(string[] args)
//    {
//        P43163 sol = new P43163();

//        // 테스트 케이스 1: 정상 변환 (예상 결과: 4)
//        // hit → hot → dot → dog → cog
//        string begin1 = "hit";
//        string target1 = "cog";
//        string[] words1 = { "hot", "dot", "dog", "lot", "log", "cog" };
//        Console.WriteLine($"Test 1: {sol.solution(begin1, target1, words1)}"); // 4

//        // 테스트 케이스 2: 변환 불가능 (예상 결과: 0)
//        // target이 words에 없음
//        string begin2 = "hit";
//        string target2 = "cog";
//        string[] words2 = { "hot", "dot", "dog", "lot", "log" };
//        Console.WriteLine($"Test 2: {sol.solution(begin2, target2, words2)}"); // 0

//        // 테스트 케이스 3: 직접 변환 (예상 결과: 1)
//        string begin3 = "hit";
//        string target3 = "hot";
//        string[] words3 = { "hot", "dot", "dog" };
//        Console.WriteLine($"Test 3: {sol.solution(begin3, target3, words3)}"); // 1
//    }
//}