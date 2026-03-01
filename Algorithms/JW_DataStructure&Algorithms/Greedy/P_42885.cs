//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/42885
//class P_42885
//{
//    public int solution(int[] people, int limit)
//    {
//        int answer = 0;
//        int sum = 0;
//        int count = 0;

//        Array.Sort(people);

//        int left = 0;
//        int right = people.Length - 1;
//        //people 배열을 순회한다

//        while (left <= right)
//        {
//            if (people[left] + people[right] <= limit)
//            {
//                left++;
//                right--;
//            }
//            else
//            {
//                right--;
//            }
//            answer++;
//        }



//        return answer;
//    }

//    static void Main(string[] args)
//    {
//        var solution = new P_42885();

//        // 테스트 1
//        Console.WriteLine($"테스트 1: {solution.solution(new int[] { 70, 50, 80, 50 }, 100)} (예상: 3)");

//        // 테스트 2
//        Console.WriteLine($"테스트 2: {solution.solution(new int[] { 70, 80, 50 }, 100)} (예상: 3)");

//        // 테스트 3: 모두 한 명씩
//        Console.WriteLine($"테스트 3: {solution.solution(new int[] { 80, 90, 70, 60 }, 100)} (예상: 4)");

//        // 테스트 4: 모두 두 명씩
//        Console.WriteLine($"테스트 4: {solution.solution(new int[] { 40, 40, 40, 40 }, 100)} (예상: 2)");

//        // 테스트 5: 한 명은 혼자, 나머지는 둘씩
//        Console.WriteLine($"테스트 5: {solution.solution(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }, 100)} (예상: 5)");

//        // 테스트 6: 최소 케이스
//        Console.WriteLine($"테스트 6: {solution.solution(new int[] { 50 }, 100)} (예상: 1)");

//        // 테스트 7: 가벼운 사람과 무거운 사람
//        Console.WriteLine($"테스트 7: {solution.solution(new int[] { 20, 50, 50, 80 }, 100)} (예상: 3)");

//        Console.WriteLine("\n테스트 완료!");
//    }
//}