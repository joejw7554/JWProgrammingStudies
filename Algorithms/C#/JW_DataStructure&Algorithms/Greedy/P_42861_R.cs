//using System;
//using System.Collections.Generic;


////https://school.programmers.co.kr/learn/courses/30/lessons/42861
//public class P_42861_R
//{

//    public int solution(int n, int[,] costs)
//    {
//        int answer = 0;


//        return answer;
//    }


//    static void Main()
//    {
//        var solution = new P_42861_R();

//        // 테스트 1: 프로그래머스 기본 예제
//        int[,] costs1 = new int[,] 
//        { 
//            { 0, 1, 1 }, 
//            { 0, 2, 2 }, 
//            { 1, 2, 5 }, 
//            { 1, 3, 1 }, 
//            { 2, 3, 8 } 
//        };
//        Console.WriteLine($"테스트 1: {solution.solution(4, costs1)} (예상: 4)");

//        // 테스트 2: 간단한 3개 섬
//        int[,] costs2 = new int[,] 
//        { 
//            { 0, 1, 1 }, 
//            { 1, 2, 1 }, 
//            { 0, 2, 2 } 
//        };
//        Console.WriteLine($"테스트 2: {solution.solution(3, costs2)} (예상: 2)");

//        // 테스트 3: 직선 연결
//        int[,] costs3 = new int[,] 
//        { 
//            { 0, 1, 5 }, 
//            { 1, 2, 3 }, 
//            { 2, 3, 2 } 
//        };
//        Console.WriteLine($"테스트 3: {solution.solution(4, costs3)} (예상: 10)");

//        // 테스트 4: 완전 그래프 (모든 섬이 연결)
//        int[,] costs4 = new int[,] 
//        { 
//            { 0, 1, 1 }, 
//            { 0, 2, 3 }, 
//            { 1, 2, 2 } 
//        };
//        Console.WriteLine($"테스트 4: {solution.solution(3, costs4)} (예상: 3)");

//        // 테스트 5: 5개 섬
//        int[,] costs5 = new int[,] 
//        { 
//            { 0, 1, 1 }, 
//            { 0, 2, 2 }, 
//            { 1, 2, 5 }, 
//            { 1, 3, 1 }, 
//            { 3, 4, 2 } 
//        };
//        Console.WriteLine($"테스트 5: {solution.solution(5, costs5)} (예상: 6)");

//        Console.WriteLine("\n테스트 완료!");
//    }
//}