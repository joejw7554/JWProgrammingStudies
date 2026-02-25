//using System;
//using System.Collections.Generic;
//using System.Linq;

////https://school.programmers.co.kr/learn/courses/30/lessons/42862
//public class P_42862
//{
//    public int solution(int n, int[] lost, int[] reserve)
//    {
//        int answer = 0;

//        //reserve 중에 lost 한 애가 있다면 reserve와 lost에서 제거한다
//        HashSet<int> lostHash = lost.ToHashSet();
//        HashSet<int> reserveHash = reserve.ToHashSet();

//        var reserveLost = reserveHash.Intersect(lostHash);

//        lostHash = lostHash.Except(reserveLost).OrderBy(x=>x).ToHashSet();
//        reserveHash= reserveHash.Except(reserveLost).ToHashSet();

//        //그런다음 lost에서 +1 또는 -1을 통해 있으면 제거해준다
//        foreach (var reserveStudent in reserveHash.OrderBy(x=>x))
//        {
//            if (lostHash.Contains(reserveStudent - 1))
//            {
//                lostHash.Remove(reserveStudent - 1);
//            }
//            else if (lostHash.Contains(reserveStudent + 1))
//            {
//                lostHash.Remove(reserveStudent + 1);
//            }
//        }

//        answer = n - lostHash.Count;

//        return answer;
//    }

//    static void Main(string[] args)
//    {
//        var solution = new P_42862();

//        // 테스트 1
//        Console.WriteLine($"테스트 1: {solution.solution(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 })} (예상: 5)");

//        // 테스트 2
//        Console.WriteLine($"테스트 2: {solution.solution(5, new int[] { 2, 4 }, new int[] { 3 })} (예상: 4)");

//        // 테스트 3
//        Console.WriteLine($"테스트 3: {solution.solution(3, new int[] { 3 }, new int[] { 1 })} (예상: 2)");

//        // 테스트 4: 여벌 가진 학생이 도난당한 경우
//        Console.WriteLine($"테스트 4: {solution.solution(5, new int[] { 2, 4 }, new int[] { 2, 4 })} (예상: 5)");

//        // 테스트 5: 순서가 중요한 케이스
//        Console.WriteLine($"테스트 5: {solution.solution(5, new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 })} (예상: 4)");// 디버깅 필요

//        // 테스트 6
//        Console.WriteLine($"테스트 6: {solution.solution(7, new int[] { 2, 3, 4 }, new int[] { 1, 5 })} (예상: 6)"); // 디버깅 필요

//        Console.WriteLine("\n테스트 완료!");
//    }
//}