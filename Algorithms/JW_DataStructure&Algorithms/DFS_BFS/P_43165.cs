//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/43165

//public class Solution
//{
//    int answer = 0;

//    public int solution(int[] numbers, int target)
//    {
//        ////DFS
//        //Stack<(int ,int )> stack = new Stack<(int,int)>(); //currentIndex ,Sum

//        //stack.Push((0, 0));

//        //while (stack.Count > 0)
//        //{
//        //    (int currentIndex,int currentSum) pop = stack.Pop();


//        //    if (pop.currentIndex < numbers.Length)
//        //    {
//        //        stack.Push((pop.currentIndex + 1, pop.currentSum + numbers[pop.currentIndex]));
//        //        stack.Push((pop.currentIndex + 1, pop.currentSum - numbers[pop.currentIndex]));
//        //    }
//        //    else
//        //    {
//        //        if (pop.currentSum == target) answer++;
//        //        continue;
//        //    }
//        //}

//        //BFS
//        Queue<(int, int)> queue = new Queue<(int, int)>(); //index, sum

//        queue.Enqueue((0, 0));

//        while (queue.Count > 0)
//        {
//            (int index, int sum) pop = queue.Dequeue();

//            if (pop.index == numbers.Length)
//            {
//                if (pop.sum == target) answer++;

//                continue;
//            }

//            queue.Enqueue((pop.index + 1, pop.sum + numbers[pop.index]));
//            queue.Enqueue((pop.index + 1, pop.sum - numbers[pop.index]));
//        }





//        return answer;
//    }

//    // 테스트 케이스
//    static void Main()
//    {
//        Solution sol = new Solution();

//        Console.WriteLine("=== 테스트 케이스 1 (프로그래머스 예제 1) ===");
//        int result1 = sol.solution(new int[] { 1, 1, 1, 1, 1 }, 3);
//        Console.WriteLine($"입력: [1, 1, 1, 1, 1], target: 3");
//        Console.WriteLine($"출력: {result1}, 예상: 5\n");

//        Console.WriteLine("=== 테스트 케이스 2 (프로그래머스 예제 2) ===");
//        sol.answer = 0;
//        int result2 = sol.solution(new int[] { 4, 1, 2, 1 }, 4);
//        Console.WriteLine($"입력: [4, 1, 2, 1], target: 4");
//        Console.WriteLine($"출력: {result2}, 예상: 2\n");

//        Console.WriteLine("=== 테스트 케이스 3 (단일 숫자) ===");
//        sol.answer = 0;
//        int result3 = sol.solution(new int[] { 1 }, 1);
//        Console.WriteLine($"입력: [1], target: 1");
//        Console.WriteLine($"출력: {result3}, 예상: 1\n");

//        Console.WriteLine("=== 테스트 케이스 4 (불가능한 경우) ===");
//        sol.answer = 0;
//        int result4 = sol.solution(new int[] { 1, 1, 1 }, 5);
//        Console.WriteLine($"입력: [1, 1, 1], target: 5");
//        Console.WriteLine($"출력: {result4}, 예상: 0\n");

//        Console.WriteLine("=== 테스트 케이스 5 (0 포함) ===");
//        sol.answer = 0;
//        int result5 = sol.solution(new int[] { 0, 0, 1 }, 1);
//        Console.WriteLine($"입력: [0, 0, 1], target: 1");
//        Console.WriteLine($"출력: {result5}, 예상: 4\n");

//        Console.WriteLine("=== 테스트 케이스 6 (큰 숫자) ===");
//        sol.answer = 0;
//        int result6 = sol.solution(new int[] { 10, 20, 30 }, 0);
//        Console.WriteLine($"입력: [10, 20, 30], target: 0");
//        Console.WriteLine($"출력: {result6}, 예상: 2\n");
//    }
//}
