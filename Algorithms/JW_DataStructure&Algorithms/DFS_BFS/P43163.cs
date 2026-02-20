using System;
using System.Collections.Generic;
public class P43163
{

   

    //https://school.programmers.co.kr/learn/courses/30/lessons/43163?language=csharp
    public int solution(string begin, string target, string[] words)
    {
        int answer = int.MaxValue;

        //BFS


        //Queue에서 꺼낸다 형태는 string , int 바꾼횟수 
        var queue = new Queue<(string, int)>();

        queue.Enqueue((begin, 0));

        //단어가 하나만 다른것만 집어넣는다 ?? 아니면 단어가 2개 같은것만 집어넣는다
        while (queue.Count > 0)
        {
            (string word, int count) current =queue.Dequeue();

            if(string.Compare(current.word, target)==0)
            {
                answer = current.count;
                return answer;
            }

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != current.word[i])
                    {
                        queue.Enqueue((word, current.count + 1));
                    }
                }

            }
        }

        if(answer==int.MaxValue)//안바꼈다는건 방법이 없다는뜻
        {
            return 0;
        }

        return answer;
    }

    static void Main(string[] args)
    {
        P43163 sol = new P43163();

        // 테스트 케이스 1: 정상 변환 (예상 결과: 4)
        // hit → hot → dot → dog → cog
        string begin1 = "hit";
        string target1 = "cog";
        string[] words1 = { "hot", "dot", "dog", "lot", "log", "cog" };
        Console.WriteLine($"Test 1: {sol.solution(begin1, target1, words1)}"); // 4

        // 테스트 케이스 2: 변환 불가능 (예상 결과: 0)
        // target이 words에 없음
        string begin2 = "hit";
        string target2 = "cog";
        string[] words2 = { "hot", "dot", "dog", "lot", "log" };
        Console.WriteLine($"Test 2: {sol.solution(begin2, target2, words2)}"); // 0

        // 테스트 케이스 3: 직접 변환 (예상 결과: 1)
        string begin3 = "hit";
        string target3 = "hot";
        string[] words3 = { "hot", "dot", "dog" };
        Console.WriteLine($"Test 3: {sol.solution(begin3, target3, words3)}"); // 1
    }
}