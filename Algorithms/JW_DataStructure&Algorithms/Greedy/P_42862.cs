//using System.Collections.Generic;
//using System.Text;
//using System;

////https://school.programmers.co.kr/learn/courses/30/lessons/42862
//public class Solution
//{
//    public int solution(int n, int[] lost, int[] reserve)
//    {
//        int answer = n;

//        Array.Sort(lost);
//        Array.Sort(reserve);

//        //reserve와 lost 동시에 있는 학생 찾아서 -1로 표기
//        for (int i = 0; i < reserve.Length; i++)
//        {
//            for (int j = 0;j < lost.Length; j++)
//                {
//                    if (lost[j] == reserve[i]) 
//                    {
//                        lost[j] = -1;
//                        reserve[i] = -1;
//                        break;
//                    }
//                }

//        }


//        //reserve학생들의 인접한 한생 빌려주기
//        foreach (var item in reserve)
//        {
//            for (int i = 0; i < lost.Length; i++)
//            {
//                if (item == -1) continue;//자기가 입어야했던 애들은 패스

//                if ((item + 1 == lost[i]) || (item - 1 == lost[i])) //여벌이 있는 애들
//                {
//                    lost[i] = -1;
//                    break;
//                }
//            }
//        }

//        int count = lost.Count((x => x > 0));
//        answer -= count;

//        return answer;
//    }

//        //반복문 끝난뒤에 n-count하면 값이 나올꺼같다
//    static void Main()
//    {
//        var sol = new Solution();
//        sol.solution(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 });
//    }
//}



using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;

//https://school.programmers.co.kr/learn/courses/30/lessons/42862
public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        var lostHash = lost.ToHashSet();
        var reserveHash = reserve.ToHashSet();

        var lostStudent = reserve.Intersect(lostHash);

        reserveHash.ExceptWith(lostStudent);
        lostHash.ExceptWith(lostStudent);

        foreach (var item in reserveHash.Order())
        {
            if (lostHash.Contains(item + 1))
            {
                lostHash.Remove(item + 1);
            }
            else if (lostHash.Contains(item - 1))
            {
                lostHash.Remove(item - 1);
            }
        }

        return n - lostHash.Count;
    }


    static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.solution(5, new int[] { 1, 4 }, new int[] { 1, 3, 5 })); // 5
    }
}