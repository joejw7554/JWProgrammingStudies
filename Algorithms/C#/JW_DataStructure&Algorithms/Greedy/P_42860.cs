//using System;
//using System.Collections.Generic;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/42860
//class P_42860
//{
//    public class Solution
//    {
//        public int solution(string name)
//        {
//            int answer = 0;


//            for (int i = 0; i < name.Length; i++)
//            {
//                int upCount = name[i] - 'A';
//                int downCount = 'Z' - name[i] + 1;

//                answer += Math.Min(upCount, downCount);
//            }

//            int minMove = name.Length - 1;

//            for (int i = 0; i < name.Length; i++)
//            {
//                int nextIdx = i + 1;
//                while (nextIdx < name.Length && name[nextIdx] == 'A')
//                {
//                    nextIdx++;
//                }

//                minMove = Math.Min(minMove,
//                    Math.Min(i * 2 + name.Length - nextIdx, (name.Length - nextIdx) * 2 + i));
//            }

//            answer += minMove;
//            return answer;
//        }

//    }

//    static void Main(string[] args)
//    {
//        var solution = new Solution();

//        // 테스트 1
//        Console.WriteLine($"테스트 1: {solution.solution("ABC")} (예상: 5)");

//        // 테스트 2
//        Console.WriteLine($"테스트 2: {solution.solution("JAN")} (예상: 23)");

//        // 테스트 3
//        Console.WriteLine($"테스트 3: {solution.solution("JAZ")} (예상: 11)");

//        // 테스트 4
//        Console.WriteLine($"테스트 4: {solution.solution("BBBBAAAABA")} (예상: 12)");

//        // 테스트 5
//        Console.WriteLine($"테스트 5: {solution.solution("AAAA")} (예상: 0)");

//        // 테스트 6
//        Console.WriteLine($"테스트 6: {solution.solution("ABAAAAAAAAABB")} (예상: 7)");

//        Console.WriteLine("\n테스트 완료!");
//    }
//}
